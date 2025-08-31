namespace Kaioordinate
{
    partial class kaiEventMaintenanceForm
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lstEvent = new System.Windows.Forms.ListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pCboLocation = new System.Windows.Forms.ComboBox();
            this.pBtnCancel = new FontAwesome.Sharp.IconButton();
            this.pBtnSave = new FontAwesome.Sharp.IconButton();
            this.pDtpTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pTxtEventName = new System.Windows.Forms.TextBox();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(595, 247);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(259, 34);
            this.dtpDate.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(449, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 65;
            this.label4.Text = "Event Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(464, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 64;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(417, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "Event Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(459, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Event ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(493, 447);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 115);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(342, 447);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 115);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.Location = new System.Drawing.Point(161, 447);
            this.btnDown.Name = "btnDown";
            this.btnDown.Rotation = 180D;
            this.btnDown.Size = new System.Drawing.Size(132, 115);
            this.btnDown.TabIndex = 57;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(595, 182);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(123, 34);
            this.txtLocation.TabIndex = 55;
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(595, 117);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(259, 34);
            this.txtEventName.TabIndex = 54;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(595, 60);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(114, 34);
            this.txtID.TabIndex = 53;
            // 
            // lstEvent
            // 
            this.lstEvent.FormattingEnabled = true;
            this.lstEvent.ItemHeight = 16;
            this.lstEvent.Location = new System.Drawing.Point(34, 37);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.Size = new System.Drawing.Size(325, 340);
            this.lstEvent.TabIndex = 52;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pCboLocation);
            this.panel.Controls.Add(this.pBtnCancel);
            this.panel.Controls.Add(this.pBtnSave);
            this.panel.Controls.Add(this.pDtpTime);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.pTxtEventName);
            this.panel.Location = new System.Drawing.Point(26, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1007, 398);
            this.panel.TabIndex = 84;
            this.panel.Visible = false;
            // 
            // pCboLocation
            // 
            this.pCboLocation.FormattingEnabled = true;
            this.pCboLocation.Location = new System.Drawing.Point(531, 188);
            this.pCboLocation.Name = "pCboLocation";
            this.pCboLocation.Size = new System.Drawing.Size(261, 24);
            this.pCboLocation.TabIndex = 101;
            // 
            // pBtnCancel
            // 
            this.pBtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pBtnCancel.IconColor = System.Drawing.Color.Black;
            this.pBtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pBtnCancel.Location = new System.Drawing.Point(632, 340);
            this.pBtnCancel.Name = "pBtnCancel";
            this.pBtnCancel.Size = new System.Drawing.Size(144, 40);
            this.pBtnCancel.TabIndex = 100;
            this.pBtnCancel.Text = "Cancel";
            this.pBtnCancel.UseVisualStyleBackColor = true;
            this.pBtnCancel.Click += new System.EventHandler(this.pBtnCancel_Click);
            // 
            // pBtnSave
            // 
            this.pBtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pBtnSave.IconColor = System.Drawing.Color.Black;
            this.pBtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pBtnSave.Location = new System.Drawing.Point(406, 340);
            this.pBtnSave.Name = "pBtnSave";
            this.pBtnSave.Size = new System.Drawing.Size(144, 40);
            this.pBtnSave.TabIndex = 99;
            this.pBtnSave.Text = "Save";
            this.pBtnSave.UseVisualStyleBackColor = true;
            this.pBtnSave.Click += new System.EventHandler(this.pBtnSave_Click);
            // 
            // pDtpTime
            // 
            this.pDtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pDtpTime.Location = new System.Drawing.Point(532, 256);
            this.pDtpTime.Name = "pDtpTime";
            this.pDtpTime.Size = new System.Drawing.Size(260, 34);
            this.pDtpTime.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(401, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(376, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 85;
            this.label7.Text = "Event Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(361, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 67;
            this.label6.Text = "Event Name";
            // 
            // pTxtEventName
            // 
            this.pTxtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTxtEventName.Location = new System.Drawing.Point(532, 118);
            this.pTxtEventName.Name = "pTxtEventName";
            this.pTxtEventName.Size = new System.Drawing.Size(260, 34);
            this.pTxtEventName.TabIndex = 65;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.Location = new System.Drawing.Point(26, 447);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(129, 115);
            this.btnUp.TabIndex = 85;
            this.btnUp.Text = "UP";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(666, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 115);
            this.btnDelete.TabIndex = 86;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(915, 447);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 115);
            this.btnReturn.TabIndex = 87;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // kaiEventMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1085, 590);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lstEvent);
            this.Name = "kaiEventMaintenanceForm";
            this.Text = "Event Maintenance";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
    
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListBox lstEvent;
      
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DateTimePicker pDtpTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pTxtEventName;
        private FontAwesome.Sharp.IconButton pBtnCancel;
        private FontAwesome.Sharp.IconButton pBtnSave;
        private System.Windows.Forms.ComboBox pCboLocation;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReturn;
    }
}