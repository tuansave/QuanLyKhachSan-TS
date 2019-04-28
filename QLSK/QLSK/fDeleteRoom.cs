﻿using QuanLyKhachSan.DAO;
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
using QLSK;
namespace QLSK
{
    public partial class fDeleteRoom : Form

    {
        MainMenu m = new MainMenu();
        RoomDTO _room = new RoomDTO();
        fRoom _froom = new fRoom();
        public fDeleteRoom(fRoom f)
        {
            InitializeComponent();
            _froom = f;
            LoadRoomList();
        }
        public void LoadRoomList()
        {
            dtgvPhong.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.ExecuteLoadInforRoomQuery());
        }

        public fDeleteRoom(fRoom f, MainMenu main)
        {
            InitializeComponent();
            _froom = f;
            m = main;
            LoadRoomList();
        }
        private void dtgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _room.RoomCode = int.Parse(dtgvPhong.CurrentRow.Cells[0].Value.ToString());
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public Button getRoomInfo()
        {
            List<RoomDTO> RoomList = RoomDAO.Instance.LoadRoomList();
            Button btn = new Button();
            foreach (RoomDTO roomDTO in RoomList)
            {
                if (_room.RoomCode == roomDTO.RoomCode)
                {
                    btn.Text = roomDTO.RoomName;
                    break;
                }
            }
            return btn;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button DeleteButton = getRoomInfo();
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá phòng?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int data = RoomDAO.Instance.deleteRoomDatabaseQuery(_room.RoomCode);
                    //return data(int) > 0 is success
                    if (data > 0)
                    {
                        MessageBox.Show("Xóa phòng thành công");
                        _froom.LoadRoomList();
                        LoadRoomList();

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa phòng thất bại ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
