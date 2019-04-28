﻿using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSK
{
    public partial class fEditRoom: Form
    {
        RoomDTO _room = new RoomDTO();
        fRoom _fRoom = new fRoom();
        MainMenu m = new MainMenu();
        public fEditRoom(fRoom f = null, MainMenu main = null)
        {

            InitializeComponent();
            _fRoom = f;
            setDataStatusRoomNew();
            setDataStyleRoomNew();
           
            m = main;
        }
        public string[] GetRoomChangedInfo(Button btn)
        {
            string ChangedValue = "";
            ChangedValue += txbRoomCodeOld.Text.ToString() + '@';
            ChangedValue += btn.Text + '@';
            ChangedValue += txtRoomCodeNew.Text.ToString() + '@';
            ChangedValue += txbRoomNameNew.Text.ToString() + '@';
            ChangedValue += txbRoomNoteNew.Text.ToString() + '@';
            ChangedValue += _room.RoomStyle.ToString() + '@';
            ChangedValue += _room.RoomStatus.ToString();
            return ChangedValue.Split('@');
        }
        public Button getRoomInfo()
        {
            List<RoomDTO> RoomList = RoomDAO.Instance.LoadRoomList();
            Button btn = new Button();
            foreach (RoomDTO roomDTO in RoomList)
            {
                if (getRoomCodeOld() == roomDTO.RoomCode)
                {
                    btn.Text = roomDTO.RoomName;
                    break;
                }
            }
            return btn;
        }
        private void setDataStyleRoomNew()
        {
            cbxRoomStyleNew.DisplayMember = "TenLoaiPhong";
            cbxRoomStyleNew.ValueMember = "MaLoaiPhong";
            cbxRoomStyleNew.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataStyleRoomQuery());
        }

        private void setDataStatusRoomNew()
        {
            cbxRoomStatusNew.DisplayMember = "TenTinhTrang";
            cbxRoomStatusNew.ValueMember = "MaTinhTrang";
            cbxRoomStatusNew.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setDataRoomStatusQuery());
        }

        private int getRoomCodeOld()
        {
            return int.Parse(txbRoomCodeOld.Text.ToString());

        }
        private RoomDTO getCodeRoomNew()
        {
            _room.RoomCode = int.Parse(txtRoomCodeNew.Text.ToString());
            return _room;
        }
        private RoomDTO getNameRoomNew()
        {
            _room.RoomName = txbRoomNameNew.Text.ToString();
            return _room;
        }

        private RoomDTO getNoteRoomNew()
        {
            _room.RoomNote = txbRoomNoteNew.Text.ToString();
            return _room;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbRoomCodeOld_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxRoomStyleNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoomStyleNew.SelectedItem != null)
            {
                DataRowView drv = cbxRoomStyleNew.SelectedItem as DataRowView;
                _room.RoomStyle = int.Parse(cbxRoomStyleNew.SelectedValue.ToString());
            }
        }

        private void cbxRoomStatusNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRoomStatusNew.SelectedItem != null)
            {
                DataRowView drv = cbxRoomStatusNew.SelectedItem as DataRowView;
                _room.RoomStatus = int.Parse(cbxRoomStatusNew.SelectedValue.ToString());
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string queryExits = "if EXISTS(SELECT * FROM PHONG Where MaPhong = " + getRoomCodeOld() + ") select 1";
                DataTable rs = DataProvide.Instance.ExecuteQuery(queryExits);
                if (rs.Rows.Count > 0)
                {
                    Button btn = getRoomInfo();
                    //return data ( int ) < 0 is success 
                    int data = DataProvide.Instance.ExecuteNonQuery(RoomDAO.Instance.UpdateRoomDatabaseQuery(), new object[] { getCodeRoomNew().RoomCode, getNameRoomNew().RoomName, _room.RoomStyle, getNoteRoomNew().RoomNote, _room.RoomStatus, getRoomCodeOld() });
                    if (data < 0)
                    {
                        MessageBox.Show("Sửa phòng thành công");
                       
                    }
                }
                else
                {
                    MessageBox.Show("Mã phòng cần sửa không tồn tại");
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException) MessageBox.Show("Lỗi dữ liệu");
                MessageBox.Show("Nhập thông tin cần sửa");
            }
        }
    }
}
