
namespace Yahoo_Finance_Scraper
{
    partial class frmTicker
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
            this.txtTiker = new System.Windows.Forms.TextBox();
            this.btnScrape = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rtbTickerInformation = new System.Windows.Forms.RichTextBox();
            this.lblTicker = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTiker
            // 
            this.txtTiker.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTiker.Location = new System.Drawing.Point(361, 56);
            this.txtTiker.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiker.Name = "txtTiker";
            this.txtTiker.Size = new System.Drawing.Size(128, 26);
            this.txtTiker.TabIndex = 0;
            this.txtTiker.Text = "AAPL";
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(243, 144);
            this.btnScrape.Margin = new System.Windows.Forms.Padding(4);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(128, 31);
            this.btnScrape.TabIndex = 1;
            this.btnScrape.Text = "SCRAPE";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScraper_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(361, 103);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(128, 26);
            this.dtpDate.TabIndex = 2;
            // 
            // rtbTickerInformation
            // 
            this.rtbTickerInformation.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTickerInformation.Location = new System.Drawing.Point(139, 183);
            this.rtbTickerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.rtbTickerInformation.Name = "rtbTickerInformation";
            this.rtbTickerInformation.Size = new System.Drawing.Size(337, 208);
            this.rtbTickerInformation.TabIndex = 3;
            this.rtbTickerInformation.Text = " ";
            // 
            // lblTicker
            // 
            this.lblTicker.AutoSize = true;
            this.lblTicker.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicker.ForeColor = System.Drawing.Color.White;
            this.lblTicker.Location = new System.Drawing.Point(115, 56);
            this.lblTicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicker.Name = "lblTicker";
            this.lblTicker.Size = new System.Drawing.Size(136, 23);
            this.lblTicker.TabIndex = 4;
            this.lblTicker.Text = "Choose the Ticker";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(115, 108);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(126, 23);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Choose the Date";
            // 
            // frmTicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(589, 437);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTicker);
            this.Controls.Add(this.rtbTickerInformation);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnScrape);
            this.Controls.Add(this.txtTiker);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTicker";
            this.Text = "Yahoo! Finance Ticker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTiker;
        private System.Windows.Forms.Button btnScrape;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RichTextBox rtbTickerInformation;
        private System.Windows.Forms.Label lblTicker;
        private System.Windows.Forms.Label lblDate;
    }
}

