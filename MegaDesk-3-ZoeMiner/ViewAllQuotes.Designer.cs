﻿namespace MegaDesk_3_ZoeMiner
{
    partial class ViewAllQuotes
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
            this.cancelViewAllQuotesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelViewAllQuotesBtn
            // 
            this.cancelViewAllQuotesBtn.Location = new System.Drawing.Point(312, 390);
            this.cancelViewAllQuotesBtn.Name = "cancelViewAllQuotesBtn";
            this.cancelViewAllQuotesBtn.Size = new System.Drawing.Size(160, 48);
            this.cancelViewAllQuotesBtn.TabIndex = 3;
            this.cancelViewAllQuotesBtn.Text = "Cancel";
            this.cancelViewAllQuotesBtn.UseVisualStyleBackColor = true;
            this.cancelViewAllQuotesBtn.Click += new System.EventHandler(this.cancelViewAllQuotesBtn_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelViewAllQuotesBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelViewAllQuotesBtn;
    }
}