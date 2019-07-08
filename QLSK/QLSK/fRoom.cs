using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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
        RoomDTO _room = new RoomDTO();
       public  int oldRoomCode;

       
        public fRoom()
        {
            InitializeComponent();
            LoadRoomList();
            
        }
       
       public void LoadRoomList()
        {
            dtgvRoom.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.ExecuteLoadInforRoomQuery());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDeleteRoom f = new fDeleteRoom(this);
            f.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            fMain f = new fMain();
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddRoom _addRoom = new fAddRoom(this/*, m*/);
            this.Hide();
            _addRoom.ShowDialog();
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fSearch _searchRoom = new fSearch();
            this.Hide();
            _searchRoom.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            
            fEditRoom f = new fEditRoom();
            this.Hide();
            f.ShowDialog();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fRent f = new fRent(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

    }
}
