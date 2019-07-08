namespace QLSK
{
    partial class fSearch
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
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvDataRoom = new System.Windows.Forms.DataGridView();
            this.txbRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStyleRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRoomStatus = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusRoomSearch = new DevExpress.XtraEditors.SimpleButton();
            this.styleRoomSearch = new DevExpress.XtraEditors.SimpleButton();
            this.codeRoomSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataRoom)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kết quả : ";
            // 
            // dtgvDataRoom
            // 
            this.dtgvDataRoom.AllowUserToAddRows = false;
            this.dtgvDataRoom.AllowUserToDeleteRows = false;
            this.dtgvDataRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDataRoom.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDataRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataRoom.Location = new System.Drawing.Point(377, 101);
            this.dtgvDataRoom.Name = "dtgvDataRoom";
            this.dtgvDataRoom.ReadOnly = true;
            this.dtgvDataRoom.Size = new System.Drawing.Size(517, 233);
            this.dtgvDataRoom.TabIndex = 5;
            // 
            // txbRoom
            // 
            this.txbRoom.BackColor = System.Drawing.SystemColors.Window;
            this.txbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRoom.Location = new System.Drawing.Point(107, 6);
            this.txbRoom.Name = "txbRoom";
            this.txbRoom.Size = new System.Drawing.Size(155, 26);
            this.txbRoom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng";
            // 
            // cbxStyleRoom
            // 
            this.cbxStyleRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyleRoom.FormattingEnabled = true;
            this.cbxStyleRoom.Location = new System.Drawing.Point(107, 6);
            this.cbxStyleRoom.Name = "cbxStyleRoom";
            this.cbxStyleRoom.Size = new System.Drawing.Size(155, 28);
            this.cbxStyleRoom.TabIndex = 1;
            this.cbxStyleRoom.SelectedIndexChanged += new System.EventHandler(this.cbxStyleRoom_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tìm kiếm theo : ";
            // 
            // cbxRoomStatus
            // 
            this.cbxRoomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRoomStatus.FormattingEnabled = true;
            this.cbxRoomStatus.Location = new System.Drawing.Point(107, 6);
            this.cbxRoomStatus.Name = "cbxRoomStatus";
            this.cbxRoomStatus.Size = new System.Drawing.Size(155, 28);
            this.cbxRoomStatus.TabIndex = 1;
            this.cbxRoomStatus.SelectedValueChanged += new System.EventHandler(this.cbxRoomStatus_SelectedValueChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbxRoomStatus);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(11, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 46);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình Trạng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbRoom);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(11, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 45);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusRoomSearch);
            this.panel2.Controls.Add(this.styleRoomSearch);
            this.panel2.Controls.Add(this.codeRoomSearch);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-2, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 233);
            this.panel2.TabIndex = 7;
            // 
            // statusRoomSearch
            // 
            this.statusRoomSearch.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.statusRoomSearch.Appearance.BackColor2 = System.Drawing.Color.White;
            this.statusRoomSearch.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.statusRoomSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusRoomSearch.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.statusRoomSearch.Appearance.Options.UseBackColor = true;
            this.statusRoomSearch.Appearance.Options.UseBorderColor = true;
            this.statusRoomSearch.Appearance.Options.UseFont = true;
            this.statusRoomSearch.Appearance.Options.UseForeColor = true;
            this.statusRoomSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.statusRoomSearch.ImageOptions.Image = global::QLSK.Properties.Resources.search;
            this.statusRoomSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.statusRoomSearch.Location = new System.Drawing.Point(288, 153);
            this.statusRoomSearch.Name = "statusRoomSearch";
            this.statusRoomSearch.Size = new System.Drawing.Size(85, 34);
            this.statusRoomSearch.TabIndex = 13;
            this.statusRoomSearch.Text = "Tra cứu";
            this.statusRoomSearch.Click += new System.EventHandler(this.statusRoomSearch_Click_1);
            // 
            // styleRoomSearch
            // 
            this.styleRoomSearch.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.styleRoomSearch.Appearance.BackColor2 = System.Drawing.Color.White;
            this.styleRoomSearch.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.styleRoomSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleRoomSearch.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.styleRoomSearch.Appearance.Options.UseBackColor = true;
            this.styleRoomSearch.Appearance.Options.UseBorderColor = true;
            this.styleRoomSearch.Appearance.Options.UseFont = true;
            this.styleRoomSearch.Appearance.Options.UseForeColor = true;
            this.styleRoomSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.styleRoomSearch.ImageOptions.Image = global::QLSK.Properties.Resources.search;
            this.styleRoomSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.styleRoomSearch.Location = new System.Drawing.Point(288, 80);
            this.styleRoomSearch.Name = "styleRoomSearch";
            this.styleRoomSearch.Size = new System.Drawing.Size(85, 39);
            this.styleRoomSearch.TabIndex = 12;
            this.styleRoomSearch.Text = "Tra cứu";
            this.styleRoomSearch.Click += new System.EventHandler(this.styleRoomSearch_Click);
            // 
            // codeRoomSearch
            // 
            this.codeRoomSearch.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.codeRoomSearch.Appearance.BackColor2 = System.Drawing.Color.White;
            this.codeRoomSearch.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.codeRoomSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeRoomSearch.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.codeRoomSearch.Appearance.Options.UseBackColor = true;
            this.codeRoomSearch.Appearance.Options.UseBorderColor = true;
            this.codeRoomSearch.Appearance.Options.UseFont = true;
            this.codeRoomSearch.Appearance.Options.UseForeColor = true;
            this.codeRoomSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.codeRoomSearch.ImageOptions.Image = global::QLSK.Properties.Resources.search;
            this.codeRoomSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.codeRoomSearch.Location = new System.Drawing.Point(288, 11);
            this.codeRoomSearch.Name = "codeRoomSearch";
            this.codeRoomSearch.Size = new System.Drawing.Size(85, 37);
            this.codeRoomSearch.TabIndex = 11;
            this.codeRoomSearch.Text = "Tra cứu";
            this.codeRoomSearch.Click += new System.EventHandler(this.codeRoomSearch_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbxStyleRoom);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(11, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 45);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(175, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU THÔNG TIN PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 72);
            this.panel1.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnBack.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseBorderColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBack.ImageOptions.Image = global::QLSK.Properties.Resources.back;
            this.btnBack.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(752, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 76);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Trở về";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(886, 416);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgvDataRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu thông tin phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataRoom)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvDataRoom;
        private System.Windows.Forms.TextBox txbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStyleRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxRoomStatus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton codeRoomSearch;
        private DevExpress.XtraEditors.SimpleButton statusRoomSearch;
        private DevExpress.XtraEditors.SimpleButton styleRoomSearch;
        private DevExpress.XtraEditors.SimpleButton btnBack;
    }
}