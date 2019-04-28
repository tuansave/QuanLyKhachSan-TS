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
    
    public partial class fSearch : Form
    {
   
        RoomDTO _room = new RoomDTO();
        public fSearch()
        {
            InitializeComponent();

            setDataStyleRoom();
            setDataRoomStatus();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setDataStyleRoom() //value combo box theo ma loai phong
        {
            cbxStyleRoom.DisplayMember = "TenLoaiPhong";
            cbxStyleRoom.ValueMember = "MaLoaiPhong";
            cbxStyleRoom.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataStyleRoomQuery());
        }

        private void setDataRoomStatus()//value combo box theo ma loai phong
        {
            cbxRoomStatus.DisplayMember = "TenTinhTrang";
            cbxRoomStatus.ValueMember = "MaTinhTrang";
            cbxRoomStatus.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataRoomStatusQuery());
        }
        
        private RoomDTO getCodeRoom()
        {
            _room.RoomCode = int.Parse(txbRoom.Text.ToString());
            return _room;
        }
        private void codeRoomSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = RoomDAO.Instance.codeRoomSearchListQuery() + getCodeRoom().RoomCode.ToString();
                dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Mã phòng không hợp lệ");
            }
        }
        
        private void styleRoomSearch_Click(object sender, EventArgs e)
        {
            string query = RoomDAO.Instance.styleRoomSearch() + "'" + _room.RoomName + "'";
        
            dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
        }

        private void statusRoomSearch_Click_1(object sender, EventArgs e)
        {
            string query = RoomDAO.Instance.statusRoomSearch() + _room.RoomStatus;
            dtgvDataRoom.DataSource = DataProvide.Instance.ExecuteQuery(query);
        }


        private void cbxStyleRoom_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            if (cbxStyleRoom.SelectedItem != null)
            {

                DataRowView drv = cbxStyleRoom.SelectedItem as DataRowView;
                _room.RoomName = cbxStyleRoom.Text;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxRoomStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxRoomStatus.SelectedItem != null)
            {
                DataRowView drv = cbxRoomStatus.SelectedItem as DataRowView;
                _room.RoomStatus = int.Parse(cbxRoomStatus.SelectedValue.ToString());
            }
        }
    }
}
