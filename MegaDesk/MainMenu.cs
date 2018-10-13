using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openAddNewQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void openViewQuotesBtn_Click(object sender, EventArgs e)
        {
            DisplayQuotes displayQuotesForm = new DisplayQuotes();
            displayQuotesForm.Tag = this;
            displayQuotesForm.Show(this);
            Hide();
        }

        private void openSearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            Hide();
        }

        private void exitMainMenuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
