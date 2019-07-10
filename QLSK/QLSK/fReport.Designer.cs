namespace QLSK
{
    partial class fReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.dtp = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtgvReport = new System.Windows.Forms.DataGridView();
            this.cHITIET_BAOCAO_DOANHTHUTableAdapter = new QLSK.QUAN_LY_KHACH_SANDataSetTableAdapters.CHITIET_BAOCAO_DOANHTHUTableAdapter();
            this.cHITIETBAOCAODOANHTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_KHACH_SANDataSet = new QLSK.QUAN_LY_KHACH_SANDataSet();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPay = new DevExpress.XtraEditors.SimpleButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETBAOCAODOANHTHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHACH_SANDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "LẬP BÁO CÁO";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel6.Controls.Add(this.label3);
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(2, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1102, 74);
            this.panel6.TabIndex = 13;
            // 
            // dateTimeChartRangeControlClient1
            // 
            this.dateTimeChartRangeControlClient1.CustomizeSeries += new System.EventHandler<DevExpress.XtraEditors.ClientDataSourceProviderCustomizeSeriesEventArgs>(this.dateTimeChartRangeControlClient1_CustomizeSeries);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "MM/yyyy";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(152, 14);
            this.dtp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(216, 29);
            this.dtp.TabIndex = 14;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            this.dtp.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 60);
            this.panel1.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 25);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Chọn tháng";
            // 
            // dtgvReport
            // 
            this.dtgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dtgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport.Location = new System.Drawing.Point(5, 136);
            this.dtgvReport.Name = "dtgvReport";
            this.dtgvReport.Size = new System.Drawing.Size(641, 208);
            this.dtgvReport.TabIndex = 17;
            // 
            // cHITIET_BAOCAO_DOANHTHUTableAdapter
            // 
            this.cHITIET_BAOCAO_DOANHTHUTableAdapter.ClearBeforeFill = true;
            // 
            // cHITIETBAOCAODOANHTHUBindingSource
            // 
            this.cHITIETBAOCAODOANHTHUBindingSource.DataMember = "CHITIET_BAOCAO_DOANHTHU";
            this.cHITIETBAOCAODOANHTHUBindingSource.DataSource = this.qUAN_LY_KHACH_SANDataSet;
            // 
            // qUAN_LY_KHACH_SANDataSet
            // 
            this.qUAN_LY_KHACH_SANDataSet.DataSetName = "QUAN_LY_KHACH_SANDataSet";
            this.qUAN_LY_KHACH_SANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnBack.Location = new System.Drawing.Point(514, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 76);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Trở về";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrintPay
            // 
            this.btnPrintPay.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintPay.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnPrintPay.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrintPay.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPay.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnPrintPay.Appearance.Options.UseBackColor = true;
            this.btnPrintPay.Appearance.Options.UseBorderColor = true;
            this.btnPrintPay.Appearance.Options.UseFont = true;
            this.btnPrintPay.Appearance.Options.UseForeColor = true;
            this.btnPrintPay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnPrintPay.ImageOptions.Image = global::QLSK.Properties.Resources.export_pdf;
            this.btnPrintPay.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrintPay.Location = new System.Drawing.Point(5, 350);
            this.btnPrintPay.Name = "btnPrintPay";
            this.btnPrintPay.Size = new System.Drawing.Size(153, 76);
            this.btnPrintPay.TabIndex = 34;
            this.btnPrintPay.Text = "Xuất báo cáo";
            this.btnPrintPay.Click += new System.EventHandler(this.btnPrintPay_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 425);
            this.Controls.Add(this.btnPrintPay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtgvReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "fReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.fReport_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETBAOCAODOANHTHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHACH_SANDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
     
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private MetroFramework.Controls.MetroDateTime dtp;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dtgvReport;
        private QUAN_LY_KHACH_SANDataSetTableAdapters.CHITIET_BAOCAO_DOANHTHUTableAdapter cHITIET_BAOCAO_DOANHTHUTableAdapter;
        private QUAN_LY_KHACH_SANDataSet qUAN_LY_KHACH_SANDataSet;
        private System.Windows.Forms.BindingSource cHITIETBAOCAODOANHTHUBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnPrintPay;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}