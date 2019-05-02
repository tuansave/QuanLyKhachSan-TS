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
    public partial class fUpdateRoomPrice : Form
    {
        public fUpdateRoomPrice()
        {
            InitializeComponent();
            LoadListRoomTypeID();
        }
        void LoadListRoomTypeID()
        {
            List<int> listID = new List<int>();
            listID = ChangeRegulationDAO.Instance.getListRoomTypeCode();
            cbListRoomType.DataSource = listID;
        }

        private void cbListRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                txbRoomTypeName.Text = ChangeRegulationDAO.Instance.getRoomTypeName((int)(cb.SelectedValue));
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int _roomTypeID = (int)cbListRoomType.SelectedValue;
            double _roomTypePrice = double.Parse(txbPrice.Text);

            ChangeRegulationDAO.Instance.UpdatePrice(_roomTypeID, _roomTypePrice);
            MessageBox.Show("Cập nhật thành công !");   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
