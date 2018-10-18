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
using Newtonsoft.Json;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void cancelSearchQuotesBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            //populate materials
            var materials = new List<Desk.SurfaceMaterial>();

            materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                   .Cast<Desk.SurfaceMaterial>()
                   .ToList();

            materialTypeInput.DataSource = materials;
            // set default to empty
            materialTypeInput.SelectedIndex = -1;

            // Populate Grid
            DataTable table = new DataTable();
            table.Columns.Add("Date");
            table.Columns.Add("Material");
            table.Columns.Add("Width");
            table.Columns.Add("Depth");
            table.Columns.Add("Drawers");
            table.Columns.Add("Shipping");
            table.Columns.Add("Price");
            table.Columns.Add("Name");

            string text = File.ReadAllText(@"quotes.json");
            var list = JsonConvert.DeserializeObject<List<DeskQuote>>(text);
            foreach (var item in list)
            {
                table.Rows.Add(item.Date, item.Desk.Material, item.Desk.Width, item.Desk.Depth, item.Desk.Drawers, item.Shipping, item.Price, item.Customer);
            }

            displayDataGrid.DataSource = table;
        }

        private void materialTypeInput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Desk.SurfaceMaterial material = (Desk.SurfaceMaterial)materialTypeInput.SelectedItem;

            // Populate Grid
            DataTable table = new DataTable();
            table.Columns.Add("Date");
            table.Columns.Add("Material");
            table.Columns.Add("Width");
            table.Columns.Add("Depth");
            table.Columns.Add("Drawers");
            table.Columns.Add("Shipping");
            table.Columns.Add("Price");
            table.Columns.Add("Name");

            string text = File.ReadAllText(@"quotes.json");
            var list = JsonConvert.DeserializeObject<List<DeskQuote>>(text);
            foreach (var item in list)
            {
                if (item.Desk.Material == material)
                {
                    table.Rows.Add(item.Date, item.Desk.Material, item.Desk.Width, item.Desk.Depth, item.Desk.Drawers, item.Shipping, item.Price, item.Customer);
                }
            }
            displayDataGrid.DataSource = table;
        }
    }
}
