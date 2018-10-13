namespace MegaDesk
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
            this.displayDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTypeInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelSearchQuotesBtn
            // 
            this.cancelSearchQuotesBtn.Location = new System.Drawing.Point(198, 315);
            this.cancelSearchQuotesBtn.Name = "cancelSearchQuotesBtn";
            this.cancelSearchQuotesBtn.Size = new System.Drawing.Size(160, 48);
            this.cancelSearchQuotesBtn.TabIndex = 3;
            this.cancelSearchQuotesBtn.Text = "Cancel";
            this.cancelSearchQuotesBtn.UseVisualStyleBackColor = true;
            this.cancelSearchQuotesBtn.Click += new System.EventHandler(this.cancelSearchQuotesBtn_Click);
            // 
            // displayDataGrid
            // 
            this.displayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGrid.Location = new System.Drawing.Point(12, 67);
            this.displayDataGrid.Name = "displayDataGrid";
            this.displayDataGrid.ReadOnly = true;
            this.displayDataGrid.Size = new System.Drawing.Size(547, 235);
            this.displayDataGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // materialTypeInput
            // 
            this.materialTypeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTypeInput.FormattingEnabled = true;
            this.materialTypeInput.Location = new System.Drawing.Point(88, 15);
            this.materialTypeInput.Name = "materialTypeInput";
            this.materialTypeInput.Size = new System.Drawing.Size(158, 32);
            this.materialTypeInput.TabIndex = 6;
            this.materialTypeInput.SelectionChangeCommitted += new System.EventHandler(this.materialTypeInput_SelectionChangeCommitted);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 372);
            this.Controls.Add(this.materialTypeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayDataGrid);
            this.Controls.Add(this.cancelSearchQuotesBtn);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuotesBtn;
        private System.Windows.Forms.DataGridView displayDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialTypeInput;
    }
}