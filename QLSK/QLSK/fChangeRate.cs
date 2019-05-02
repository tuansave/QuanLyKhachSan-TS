﻿using QuanLyKhachSan.DAO;
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
    public partial class fChangeRate : Form
    {
        public fChangeRate()
        {
            InitializeComponent();
            LoadListRate();
        }
        public void LoadListRate()
        {
            dtgvRate.DataSource = ChangeRegulationDAO.Instance.LoadListRate();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox1.Text.Length != 0)
                {
                    ChangeRegulationDAO.Instance.UpdateRate1(float.Parse(txtBox1.Text));
                    LoadListRate();
                    txtBox1.Text = string.Empty;
                }

                if (txtBox2.Text.Length != 0)
                {
                    ChangeRegulationDAO.Instance.UpdateRate2(float.Parse(txtBox2.Text));
                    LoadListRate();
                    txtBox2.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
