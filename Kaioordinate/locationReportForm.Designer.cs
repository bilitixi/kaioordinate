namespace Kaioordinate
{
    partial class locationReportForm
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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnZout = new System.Windows.Forms.Button();
            this.btnZin = new System.Windows.Forms.Button();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(571, 373);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 56);
            this.btnExport.TabIndex = 93;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(17, 164);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(91, 40);
            this.btnPrev.TabIndex = 92;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(770, 164);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 40);
            this.btnNext.TabIndex = 91;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(757, 362);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(104, 96);
            this.btnReturn.TabIndex = 90;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnZout
            // 
            this.btnZout.Location = new System.Drawing.Point(367, 373);
            this.btnZout.Name = "btnZout";
            this.btnZout.Size = new System.Drawing.Size(141, 57);
            this.btnZout.TabIndex = 89;
            this.btnZout.Text = "Zoom out";
            this.btnZout.UseVisualStyleBackColor = true;
            this.btnZout.Click += new System.EventHandler(this.btnZout_Click);
            // 
            // btnZin
            // 
            this.btnZin.Location = new System.Drawing.Point(161, 373);
            this.btnZin.Name = "btnZin";
            this.btnZin.Size = new System.Drawing.Size(141, 57);
            this.btnZin.TabIndex = 88;
            this.btnZin.Text = "Zoom In";
            this.btnZin.UseVisualStyleBackColor = true;
            this.btnZin.Click += new System.EventHandler(this.btnZin_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(136, 14);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(628, 342);
            this.printPreviewControl1.TabIndex = 87;
            // 
            // locationReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(878, 472);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnZout);
            this.Controls.Add(this.btnZin);
            this.Controls.Add(this.printPreviewControl1);
            this.Name = "locationReportForm";
            this.Text = "locationReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Button btnZout;
        private System.Windows.Forms.Button btnZin;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    }
}