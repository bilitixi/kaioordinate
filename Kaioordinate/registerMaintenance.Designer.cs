namespace Kaioordinate
{
    partial class registerMaintenance
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
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.daEvents = new System.Windows.Forms.DataGridView();
            this.daWhanau = new System.Windows.Forms.DataGridView();
            this.daRegistration = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.daEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daWhanau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(524, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 115);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(662, 463);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(132, 115);
            this.iconButton4.TabIndex = 73;
            this.iconButton4.Text = "DELETE";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(930, 463);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 115);
            this.btnReturn.TabIndex = 83;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(775, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 85;
            this.label2.Text = "Whanau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "Registration";
            // 
            // daEvents
            // 
            this.daEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daEvents.Location = new System.Drawing.Point(109, 128);
            this.daEvents.Name = "daEvents";
            this.daEvents.RowHeadersWidth = 51;
            this.daEvents.RowTemplate.Height = 24;
            this.daEvents.Size = new System.Drawing.Size(389, 178);
            this.daEvents.TabIndex = 87;
            // 
            // daWhanau
            // 
            this.daWhanau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daWhanau.Location = new System.Drawing.Point(647, 128);
            this.daWhanau.Name = "daWhanau";
            this.daWhanau.RowHeadersWidth = 51;
            this.daWhanau.Size = new System.Drawing.Size(389, 178);
            this.daWhanau.TabIndex = 88;
            // 
            // daRegistration
            // 
            this.daRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daRegistration.Location = new System.Drawing.Point(109, 370);
            this.daRegistration.Name = "daRegistration";
            this.daRegistration.RowHeadersWidth = 51;
            this.daRegistration.Size = new System.Drawing.Size(389, 178);
            this.daRegistration.TabIndex = 89;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(596, 379);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(302, 33);
            this.checkBox1.TabIndex = 91;
            this.checkBox1.Text = "Kai Preparation Assistant";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // registerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1085, 590);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.daRegistration);
            this.Controls.Add(this.daWhanau);
            this.Controls.Add(this.daEvents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.btnAdd);
            this.Name = "registerMaintenance";
            this.Text = "registerMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.daEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daWhanau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView daEvents;
        private System.Windows.Forms.DataGridView daWhanau;
        private System.Windows.Forms.DataGridView daRegistration;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}