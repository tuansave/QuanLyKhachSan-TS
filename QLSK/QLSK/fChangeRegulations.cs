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
    public partial class fChangeRegulations : Form
    {
        public fChangeRegulations()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fChangeNumOfCus f = new fChangeNumOfCus();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fChangeRoomType f = new fChangeRoomType();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fChangeMaxCus f=new fChangeMaxCus();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fChangeRate f = new fChangeRate();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
