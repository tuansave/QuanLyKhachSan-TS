using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;
namespace QLSK
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void dateTimeChartRangeControlClient1_CustomizeSeries(object sender, DevExpress.XtraEditors.ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {
            

        }

      


     

        private void btnCreat_Click(object sender, EventArgs e)
        {
            //int _month = dtp.Value.Month, _year = dtp.Value.Year;


            //try
            //{
             
            //    ReportDAO.Instance.CreateReport(_month, _year);
            //    MessageBox.Show("Tạo báo cáo thành công!");
            //}
            //catch
            //{
            //    MessageBox.Show("Tạo báo cáo thành công!");
            //}
            //dtgvReport.DataSource = ReportDAO.Instance.ViewReport(_month, _year);
            //rp1.Hide();
            //rp1.Show();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_KHACH_SANDataSet.CHITIET_BAOCAO_DOANHTHU' table. You can move, or remove it, as needed.
            this.cHITIET_BAOCAO_DOANHTHUTableAdapter.Fill(this.qUAN_LY_KHACH_SANDataSet.CHITIET_BAOCAO_DOANHTHU);

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            int _month = dtp.Value.Month, _year = dtp.Value.Year;


          
            dtgvReport.DataSource = ReportDAO.Instance.ViewReport(_month, _year);
            rp1.Hide();
            rp1.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
