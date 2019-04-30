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

namespace QLSK
{
    public partial class fRent : Form
    {
        CustomerDTO[] _customer = new CustomerDTO[5];
        fRoom f = new fRoom();
        int _formality = -1;
        //MainMenu m = new MainMenu();
   
        public fRent(fRoom room, string roomname/*, MainMenu mainMenu*/)
        {
            InitializeComponent();
            //m = mainMenu;
          //  this.txbRoomName.Text = roomname;
          //  this.txbRoomName.ReadOnly = true;
            f = room;
            loadComboBoxInDataGridView();
            setComboBoxFormality();
            setComboBoxRoomName();
        }
        public fRent()
        {
            InitializeComponent();
            loadComboBoxInDataGridView();
            setComboBoxFormality();
            
        }
        public fRent(fRoom room)
        {
            InitializeComponent();
            f = room;
            loadComboBoxInDataGridView();
            setComboBoxFormality();
            setComboBoxRoomName();
        }
        private int getRoomCode()
        {
            return RoomDAO.Instance.ReturnRoomCode(cbxRoomName.Text.ToString());
        }

        private void setComboBoxFormality()
        {
            cbxFormality.ValueMember = "MaHinhThucThue";
            cbxFormality.DisplayMember = "TenHinhThucThue";
            cbxFormality.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setComboBoxformality());
        }
        private void setComboBoxRoomName()
        {
            cbxRoomName.ValueMember = "TenPhong";
            cbxRoomName.DisplayMember = "TenPhong";
            cbxRoomName.DataSource = DataProvide.Instance.ExecuteQuery(RoomDAO.Instance.setComboBoxRoomName());
        }
        private string getBeginDay()
        {
            return dtBeginRent.Value.ToString();
        }

        public void getInforCustomer()
        {
            int i = 0;

            foreach (DataGridViewRow row in dtgvInputCustomes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    _customer[i] = new CustomerDTO();
                    _customer[i].CustomerName = row.Cells[0].Value.ToString();
                    _customer[i].CustomerStyle = int.Parse(row.Cells[1].Value.ToString());
                    _customer[i].CustomerCMND = int.Parse(row.Cells[2].Value.ToString());
                    _customer[i].CustomerAddress = row.Cells[3].Value.ToString();
                    i++;
                }
            }
        }

        void LoadListRoomAndCloseForm()
        {
            f.LoadRoomList();
            this.Close();
        }

        private void loadComboBoxInDataGridView()
        {

            customerStyle.ValueMember = "MaLoaiKhachHang";
            customerStyle.DisplayMember = "TenLoaiKhachHang";
            customerStyle.DataSource = DataProvide.Instance.ExecuteQuery("select * from LOAI_KHACHHANG ");
        }





            private void fRent_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoomDAO.Instance.checkStatusRoomisRent(getRoomCode()) == true)  // nếu phòng có thể cho thuê thì trả về true
                {
                    getInforCustomer();// tạo một danh sách đối tượng khách hàng thuê phòng

                    RoomDAO.Instance.CreateTenancyCard(getRoomCode(), _formality, getBeginDay(), dtgvInputCustomes.Rows.Count - 1);//tao phieu thue phong
                    RoomDAO.Instance.CreateTenancyCardDetail(_customer, getRoomCode(), getBeginDay());//tao chitiet-thuephong

                    MessageBox.Show("Tạo phiếu thuê phòng thành công");
                    LoadListRoomAndCloseForm();
                    //m.ReLoadRoomStatus();
                    //m.ReLoadStatusOfRooms();
                    //m.AddCustomerToBox(_customer[0].CustomerName);
                    //fViewRoom t = new fViewRoom(m.LoadRoomInfo(getRoomCode()), m.LoadRoomInfor(getRoomCode()), getRoomCode(), m);
                    //fview = new fViewRoom(t);
                }
                else   // phòng đang sửa chữa hoặc đang cho thuê
                {
                    if (RoomDAO.Instance.checkStatusRoomisRenting(getRoomCode()) == true) MessageBox.Show("Phòng này đang được cho thuê");
                    else
                    {
                        MessageBox.Show("Phòng này đang được sửa chữa");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu sai định dạng!!!");
            }
        }

        private void cbxFormality_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxFormality.SelectedItem != null)
            {
                DataRowView drv = cbxFormality.SelectedItem as DataRowView;
                _formality = int.Parse(cbxFormality.SelectedValue.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
