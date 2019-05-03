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
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.dtp = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtgvReport = new System.Windows.Forms.DataGridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.qUAN_LY_KHACH_SANDataSet = new QLSK.QUAN_LY_KHACH_SANDataSet();
            this.cHITIETBAOCAODOANHTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIET_BAOCAO_DOANHTHUTableAdapter = new QLSK.QUAN_LY_KHACH_SANDataSetTableAdapters.CHITIET_BAOCAO_DOANHTHUTableAdapter();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHACH_SANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETBAOCAODOANHTHUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 9);
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
            this.dtp.Location = new System.Drawing.Point(152, 14);
            this.dtp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(216, 29);
            this.dtp.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreat);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 60);
            this.panel1.TabIndex = 16;
            // 
            // btnCreat
            // 
            this.btnCreat.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnCreat.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnCreat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreat.Appearance.ForeColor = System.Drawing.Color.Tomato;
            this.btnCreat.Appearance.Options.UseBackColor = true;
            this.btnCreat.Appearance.Options.UseFont = true;
            this.btnCreat.Appearance.Options.UseForeColor = true;
            this.btnCreat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnCreat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreat.ImageOptions.Image = global::QLSK.Properties.Resources.pay;
            this.btnCreat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCreat.Location = new System.Drawing.Point(411, 10);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(162, 33);
            this.btnCreat.TabIndex = 18;
            this.btnCreat.Text = "Thanh Toán";
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
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
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // dtgvReport
            // 
            this.dtgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dtgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport.Location = new System.Drawing.Point(5, 136);
            this.dtgvReport.Name = "dtgvReport";
            this.dtgvReport.Size = new System.Drawing.Size(584, 333);
            this.dtgvReport.TabIndex = 17;
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.cHITIET_BAOCAO_DOANHTHUTableAdapter;
            this.chartControl1.DataBindings = null;
            this.chartControl1.DataSource = this.cHITIETBAOCAODOANHTHUBindingSource;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(300, 200);
            this.chartControl1.TabIndex = 18;
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
            // 
            // qUAN_LY_KHACH_SANDataSet
            // 
            this.qUAN_LY_KHACH_SANDataSet.DataSetName = "QUAN_LY_KHACH_SANDataSet";
            this.qUAN_LY_KHACH_SANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHITIETBAOCAODOANHTHUBindingSource
            // 
            this.cHITIETBAOCAODOANHTHUBindingSource.DataMember = "CHITIET_BAOCAO_DOANHTHU";
            this.cHITIETBAOCAODOANHTHUBindingSource.DataSource = this.qUAN_LY_KHACH_SANDataSet;
            // 
            // cHITIET_BAOCAO_DOANHTHUTableAdapter
            // 
            this.cHITIET_BAOCAO_DOANHTHUTableAdapter.ClearBeforeFill = true;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 479);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.dtgvReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "fReport";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.fReport_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHACH_SANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETBAOCAODOANHTHUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private MetroFramework.Controls.MetroDateTime dtp;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreat;
        private System.Windows.Forms.DataGridView dtgvReport;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private QUAN_LY_KHACH_SANDataSetTableAdapters.CHITIET_BAOCAO_DOANHTHUTableAdapter cHITIET_BAOCAO_DOANHTHUTableAdapter;
        private QUAN_LY_KHACH_SANDataSet qUAN_LY_KHACH_SANDataSet;
        private System.Windows.Forms.BindingSource cHITIETBAOCAODOANHTHUBindingSource;
    }
}