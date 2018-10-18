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
    public partial class DisplayQuotes : Form
    {
        public DisplayQuotes()
        {
            InitializeComponent();
        }

        private void cancelDisplayQuoteBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void DisplayQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void DisplayQuotes_Load(object sender, EventArgs e)
        {
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
    }
}
