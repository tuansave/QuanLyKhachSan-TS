using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
namespace QLSK
{

    public partial class fMain : Form
    {
        string strRoomStatus;
        public fMain()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            LoadRoom();
        }
        #region event
        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            fPayInfo f = new fPayInfo();
            this.Close();
           f.ShowDialog();
            //this.Show();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            fService f = new fService();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            fChangeRegulations f = new fChangeRegulations();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

  

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin f = new fLogin();
            f.Show();
        }
        #endregion
        private void fMain_Load(object sender, EventArgs e)
        {

        }
        void LoadRoom()
        {

            List<RoomDTO> ListRoom =RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO item in ListRoom)
            {
               
                Button btn = new Button()
                {
                    Width = RoomDAO.RoomWidth,
                    Height = RoomDAO.RoomHeigh
                };
                switch(item.RoomStatus)
                {
                    case 1:strRoomStatus = "Có thể cho thuê";
                        break;

                    case 2:
                        strRoomStatus = "Đang cho thuê";
                        break;

                    case 3:
                        strRoomStatus = "Đang sữa chữa";
                        break;
                }
                btn.Text = item.RoomName+Environment.NewLine+strRoomStatus;
                int newSize = 14;
                btn.Font = new Font(btn.Font.FontFamily, newSize);
                switch (item.RoomStatus)
                {
                    case 1: btn.BackColor = Color.Aquamarine;
                        break;
                    case 2: btn.BackColor = Color.DimGray;
                        break;
                    case 3: btn.BackColor = Color.Goldenrod;
                        break;
                }

                    flpRoom.Controls.Add(btn);
                }
             }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fRoom f = new fRoom();
            this.Hide();
            f.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            fReport f = new fReport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }

}
    

