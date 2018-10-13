using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MegaDesk;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            //populate materials
            var materials = new List<Desk.SurfaceMaterial>();

            materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                   .Cast<Desk.SurfaceMaterial>()
                   .ToList();

            surfaceInput.DataSource = materials;

            // set default to empty
            surfaceInput.SelectedIndex = -1;

            // populate shipping combobox
            var shipping = new List<DeskQuote.Delivery>();

            shipping = Enum.GetValues(typeof(DeskQuote.Delivery))
                .Cast<DeskQuote.Delivery>()
                .ToList();

            timeInput.DataSource = shipping;

            // set default to empty
            timeInput.SelectedIndex = -1;


        }

        private void cancelAddNewQuoteBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void submitAddNewQuoteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (nameInput.Text == "" || surfaceInput.SelectedItem == null || timeInput.SelectedItem == null)
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException f)
            {
                MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            widthInput.ReadOnly = true;
            depthInput.ReadOnly = true;
            drawersInput.ReadOnly = true;
            surfaceInput.Enabled = false;
            timeInput.Enabled = false;
            nameInput.ReadOnly = true;

            decimal width = widthInput.Value;
            decimal depth = depthInput.Value;
            int drawers = (int) drawersInput.Value;
            Desk.SurfaceMaterial deskMaterial = (Desk.SurfaceMaterial)surfaceInput.SelectedItem;
            DeskQuote.Delivery shipping = (DeskQuote.Delivery)timeInput.SelectedItem;
            string name = nameInput.Text;
            DateTime date = new DateTime();

            Desk desk = new Desk(width, depth, drawers, deskMaterial);
            DeskQuote quote = new DeskQuote(desk, shipping, name, date);

            decimal price = quote.GetQuote(desk, quote);
            priceOutput.Text = price.ToString();
            priceOutput.Visible = true;
            priceLabel.Visible = true;

            TextWriter file = new StreamWriter(@"../quotes.txt", true);
            file.WriteLine(quote.Shipping + "," + quote.Customer + "," + quote.Date + "," + desk.Width + "," + desk.Depth + "," + desk.Drawers + "," + desk.Material + "," + price);
            file.Close();
        }
    }
}
