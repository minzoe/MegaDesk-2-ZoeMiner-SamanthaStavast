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
            table.Columns.Add("Shipping");
            table.Columns.Add("Name");
            table.Columns.Add("Date");
            table.Columns.Add("Width");
            table.Columns.Add("Depth");
            table.Columns.Add("Drawers");
            table.Columns.Add("Material");
            table.Columns.Add("Price");

            StreamReader sr = new StreamReader(@"../quotes.txt");
            while (!sr.EndOfStream)
            {
                string[] parts = sr.ReadLine().Split(',');
                table.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);
            }

            displayDataGrid.DataSource = table;
        }
    }
}
