namespace MegaDesk_3_ZoeMiner
{
    partial class DisplayQuotes
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
            this.cancelDisplayQuoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelDisplayQuoteBtn
            // 
            this.cancelDisplayQuoteBtn.Location = new System.Drawing.Point(312, 390);
            this.cancelDisplayQuoteBtn.Name = "cancelDisplayQuoteBtn";
            this.cancelDisplayQuoteBtn.Size = new System.Drawing.Size(160, 48);
            this.cancelDisplayQuoteBtn.TabIndex = 3;
            this.cancelDisplayQuoteBtn.Text = "Cancel";
            this.cancelDisplayQuoteBtn.UseVisualStyleBackColor = true;
            this.cancelDisplayQuoteBtn.Click += new System.EventHandler(this.cancelDisplayQuoteBtn_Click);
            // 
            // DisplayQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelDisplayQuoteBtn);
            this.Name = "DisplayQuotes";
            this.Text = "DisplayQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelDisplayQuoteBtn;
    }
}