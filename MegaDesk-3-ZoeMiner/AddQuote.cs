using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ZoeMiner
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
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
        
        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            int width = (int)widthInput.Value;
            string errorMsg;
            if (!ValidWidthInput(width, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                widthInput.Select(0, widthInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(widthInput, errorMsg);
            }
        }

        private void widthInput_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(widthInput, "");
        }

        public bool ValidWidthInput(int width, out string errorMessage)
        {
            // Confirm that width is an int and above 24 and below 96
            if (24 < width && width < 96)
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "Width must be an integer between 24 and 96";
            return false;
        }

        private void depthInput_KeyUp(object sender, KeyEventArgs e)
        {
            string depth = depthInput.Text;
            string errorMsg;

            if (depth.Length == 0)
            {
                // If all conditions have been met, clear the ErrorProvider of errors.
                errorProvider1.SetError(depthInput, "");
                return;
            } else
            {

                for (var i = 0; i < depth.Length; i++)
                {
                    if (!char.IsControl(depth, i) && !char.IsDigit(depth, i))
                    {
                        // Select the text to be corrected by the user.
                        depthInput.Select(0, depthInput.Text.Length);
                        // Set errorMsg
                        errorMsg = "Depth needs to be an int between 12 and 48.";
                        // Set the ErrorProvider error with the text to display. 
                        this.errorProvider1.SetError(depthInput, errorMsg);
                        return;
                    }
                }
                if (12 > Convert.ToInt32(depth) || Convert.ToInt32(depth) > 48)
                {
                    // Set errorMsg
                    errorMsg = "Depth needs to be an int between 12 and 48.";
                    // Set the ErrorProvider error with the text to display. 
                    this.errorProvider1.SetError(depthInput, errorMsg);
                    return;
                }
                // If all conditions have been met, clear the ErrorProvider of errors.
                errorProvider1.SetError(depthInput, "");
            }
        }
    }
}
