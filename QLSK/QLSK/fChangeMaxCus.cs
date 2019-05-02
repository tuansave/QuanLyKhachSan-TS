using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSK
{
    public partial class fChangeMaxCus : Form
    {
        public fChangeMaxCus()
        {
            InitializeComponent();
            LoadMaxCus();
        }
        public void LoadMaxCus()
        {
            txbMasCusOld.Text = ChangeRegulationDAO.Instance.getMaxCus();
        }
        private void txbMasCusOld_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ChangeRegulationDAO.Instance.IsNumber(txbMasCusNew.Text) == false)
            {
                MessageBox.Show("Giá trị nhập vào phải là Số nguyên!", "Chú ý!");
                return;
            }

            if (txbMasCusNew.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống trường này!", "Chú ý!");
                return;
            }

            int max = int.Parse(txbMasCusNew.Text);

            ChangeRegulationDAO.Instance.UpdateMaxCus(max);
            LoadMaxCus();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
