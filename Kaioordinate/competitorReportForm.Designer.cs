namespace Kaioordinate
{
    partial class competitorReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(competitorReportForm));
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.printInvoices = new System.Drawing.Printing.PrintDocument();
            this.prvInvoices = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPreviewWhanau = new FontAwesome.Sharp.IconButton();
            this.btnPreviewLocationPreview = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnReport.IconColor = System.Drawing.Color.Black;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.Location = new System.Drawing.Point(161, 55);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(132, 115);
            this.btnReport.TabIndex = 87;
            this.btnReport.Text = "GENERATE REPORT";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(844, 334);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 115);
            this.btnReturn.TabIndex = 86;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printInvoices
            // 
            this.printInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoices_PrintPage);
            // 
            // prvInvoices
            // 
            this.prvInvoices.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvInvoices.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvInvoices.ClientSize = new System.Drawing.Size(400, 300);
            this.prvInvoices.Document = this.printInvoices;
            this.prvInvoices.Enabled = true;
            this.prvInvoices.Icon = ((System.Drawing.Icon)(resources.GetObject("prvInvoices.Icon")));
            this.prvInvoices.Name = "prvInvoices";
            this.prvInvoices.Visible = false;
            // 
            // btnPreviewWhanau
            // 
            this.btnPreviewWhanau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewWhanau.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPreviewWhanau.IconColor = System.Drawing.Color.Black;
            this.btnPreviewWhanau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreviewWhanau.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPreviewWhanau.Location = new System.Drawing.Point(371, 55);
            this.btnPreviewWhanau.Name = "btnPreviewWhanau";
            this.btnPreviewWhanau.Size = new System.Drawing.Size(223, 115);
            this.btnPreviewWhanau.TabIndex = 88;
            this.btnPreviewWhanau.Text = "PREVIEW CUSTOMER REPORT";
            this.btnPreviewWhanau.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPreviewWhanau.UseVisualStyleBackColor = true;
            this.btnPreviewWhanau.Click += new System.EventHandler(this.btnPreviewWhanau_Click);
            // 
            // btnPreviewLocationPreview
            // 
            this.btnPreviewLocationPreview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewLocationPreview.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPreviewLocationPreview.IconColor = System.Drawing.Color.Black;
            this.btnPreviewLocationPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreviewLocationPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPreviewLocationPreview.Location = new System.Drawing.Point(674, 55);
            this.btnPreviewLocationPreview.Name = "btnPreviewLocationPreview";
            this.btnPreviewLocationPreview.Size = new System.Drawing.Size(223, 115);
            this.btnPreviewLocationPreview.TabIndex = 89;
            this.btnPreviewLocationPreview.Text = "PREVIEW LOCATION REPORT";
            this.btnPreviewLocationPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPreviewLocationPreview.UseVisualStyleBackColor = true;
            this.btnPreviewLocationPreview.Click += new System.EventHandler(this.btnPreviewLocationPreview_Click);
            // 
            // competitorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1083, 461);
            this.Controls.Add(this.btnPreviewLocationPreview);
            this.Controls.Add(this.btnPreviewWhanau);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnReturn);
            this.Name = "competitorReportForm";
            this.Text = "Report Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Drawing.Printing.PrintDocument printInvoices;
        private System.Windows.Forms.PrintPreviewDialog prvInvoices;
        private FontAwesome.Sharp.IconButton btnPreviewWhanau;
        private FontAwesome.Sharp.IconButton btnPreviewLocationPreview;
    }
}