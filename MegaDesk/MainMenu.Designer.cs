namespace MegaDesk
{
    partial class MainMenu
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
            this.openAddNewQuoteBtn = new System.Windows.Forms.Button();
            this.openViewQuotesBtn = new System.Windows.Forms.Button();
            this.openSearchQuotesBtn = new System.Windows.Forms.Button();
            this.exitMainMenuBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openAddNewQuoteBtn
            // 
            this.openAddNewQuoteBtn.Location = new System.Drawing.Point(59, 39);
            this.openAddNewQuoteBtn.Name = "openAddNewQuoteBtn";
            this.openAddNewQuoteBtn.Size = new System.Drawing.Size(160, 48);
            this.openAddNewQuoteBtn.TabIndex = 1;
            this.openAddNewQuoteBtn.Text = "Add New Quote";
            this.openAddNewQuoteBtn.UseVisualStyleBackColor = true;
            this.openAddNewQuoteBtn.Click += new System.EventHandler(this.openAddNewQuoteBtn_Click);
            // 
            // openViewQuotesBtn
            // 
            this.openViewQuotesBtn.Location = new System.Drawing.Point(59, 113);
            this.openViewQuotesBtn.Name = "openViewQuotesBtn";
            this.openViewQuotesBtn.Size = new System.Drawing.Size(160, 48);
            this.openViewQuotesBtn.TabIndex = 2;
            this.openViewQuotesBtn.Text = "View Quotes";
            this.openViewQuotesBtn.UseVisualStyleBackColor = true;
            this.openViewQuotesBtn.Click += new System.EventHandler(this.openViewQuotesBtn_Click);
            // 
            // openSearchQuotesBtn
            // 
            this.openSearchQuotesBtn.Location = new System.Drawing.Point(59, 184);
            this.openSearchQuotesBtn.Name = "openSearchQuotesBtn";
            this.openSearchQuotesBtn.Size = new System.Drawing.Size(160, 48);
            this.openSearchQuotesBtn.TabIndex = 3;
            this.openSearchQuotesBtn.Text = "Search Quotes";
            this.openSearchQuotesBtn.UseVisualStyleBackColor = true;
            this.openSearchQuotesBtn.Click += new System.EventHandler(this.openSearchQuotesBtn_Click);
            // 
            // exitMainMenuBtn
            // 
            this.exitMainMenuBtn.Location = new System.Drawing.Point(59, 259);
            this.exitMainMenuBtn.Name = "exitMainMenuBtn";
            this.exitMainMenuBtn.Size = new System.Drawing.Size(160, 48);
            this.exitMainMenuBtn.TabIndex = 4;
            this.exitMainMenuBtn.Text = "Exit";
            this.exitMainMenuBtn.UseVisualStyleBackColor = true;
            this.exitMainMenuBtn.Click += new System.EventHandler(this.exitMainMenuBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_3_ZoeMiner.Properties.Resources.desk1;
            this.pictureBox1.Location = new System.Drawing.Point(275, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 268);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitMainMenuBtn);
            this.Controls.Add(this.openSearchQuotesBtn);
            this.Controls.Add(this.openViewQuotesBtn);
            this.Controls.Add(this.openAddNewQuoteBtn);
            this.Name = "MainMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openAddNewQuoteBtn;
        private System.Windows.Forms.Button openViewQuotesBtn;
        private System.Windows.Forms.Button openSearchQuotesBtn;
        private System.Windows.Forms.Button exitMainMenuBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

