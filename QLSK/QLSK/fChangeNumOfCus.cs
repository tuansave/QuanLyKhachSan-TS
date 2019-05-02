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
    public partial class fChangeNumOfCus : Form
    {
        public fChangeNumOfCus()
        {
            InitializeComponent();
            LoadListCusType();
        }
        public void LoadListCusType()
        {
            dtgvListCusType.DataSource = ChangeRegulationDAO.Instance.LoadListCusType();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ChangeRegulationDAO.Instance.IsNumber(txbCusTypeID.Text) == false || txbCusTypeID.Text.Length == 0)
            {
                MessageBox.Show("Mã loại khách phải là Số Nguyên, nhập lại!");
                return;
            }

            int _ID = int.Parse(txbCusTypeID.Text);
            string _Name = txbCusTypeName.Text.ToString();

            if (ChangeRegulationDAO.Instance.getListCusTypeCode().Contains(_ID))
            {
                MessageBox.Show("Mã loại khách bạn mới thêm đã tồn tại, Nhập lại!");
                return;
            }
            else
            {
                ChangeRegulationDAO.Instance.AddCusType(_ID, _Name);
                LoadListCusType();
                MessageBox.Show("Thêm mới thành công!");
            }
       
        }
    }
}
