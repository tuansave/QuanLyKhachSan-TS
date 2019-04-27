namespace QLSK
{
    partial class fRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 123);
            this.panel1.TabIndex = 4;
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
            this.btnBack.Location = new System.Drawing.Point(614, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 76);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Trở về";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDelete.ImageOptions.Image = global::QLSK.Properties.Resources.delete;
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(422, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 76);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnEdit.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseBorderColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Appearance.Options.UseForeColor = true;
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnEdit.ImageOptions.Image = global::QLSK.Properties.Resources.edit;
            this.btnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(224, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 76);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnAdd.ImageOptions.Image = global::QLSK.Properties.Resources.add;
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(12, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 76);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvStaff.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvStaff.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvStaff.Location = new System.Drawing.Point(0, -2);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.Size = new System.Drawing.Size(800, 337);
            this.dtgvStaff.TabIndex = 3;
            // 
            // fRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvStaff);
            this.Name = "fRoom";
            this.Text = "Phòng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.DataGridView dtgvStaff;
    }
}