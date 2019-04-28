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
    public partial class fRoom : Form
    {
        public fRoom()
        {
            InitializeComponent();
            LoadRoomList();
        }
        void LoadRoomList()
        {
            dtgvRoom.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.ExecuteLoadInforRoomQuery());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
