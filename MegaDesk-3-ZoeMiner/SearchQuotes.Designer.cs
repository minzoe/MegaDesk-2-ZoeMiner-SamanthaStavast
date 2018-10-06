namespace MegaDesk_3_ZoeMiner
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelSearchQuotesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelSearchQuotesBtn
            // 
            this.cancelSearchQuotesBtn.Location = new System.Drawing.Point(305, 390);
            this.cancelSearchQuotesBtn.Name = "cancelSearchQuotesBtn";
            this.cancelSearchQuotesBtn.Size = new System.Drawing.Size(160, 48);
            this.cancelSearchQuotesBtn.TabIndex = 3;
            this.cancelSearchQuotesBtn.Text = "Cancel";
            this.cancelSearchQuotesBtn.UseVisualStyleBackColor = true;
            this.cancelSearchQuotesBtn.Click += new System.EventHandler(this.cancelSearchQuotesBtn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelSearchQuotesBtn);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuotesBtn;
    }
}