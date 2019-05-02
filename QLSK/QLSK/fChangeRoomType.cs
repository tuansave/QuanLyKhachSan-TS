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
    public partial class fChangeRoomType : Form
    {
        public fChangeRoomType()
        {
            InitializeComponent();
            LoadListRoomType();
        }
        void LoadListRoomType()
        {
            dtgvListRoomType.DataSource = ChangeRegulationDAO.Instance.LoadListRoomType();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fUpdateRoomPrice _roomType = new fUpdateRoomPrice();
            _roomType.ShowDialog();
            LoadListRoomType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddRoomType _roomType = new fAddRoomType();
            _roomType.ShowDialog();
            LoadListRoomType();
        }
    }
}
