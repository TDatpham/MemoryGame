using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class frmMoDau : Form
    {
        public frmMoDau()
        {
            InitializeComponent();
            frmMovingMemory.n = 16;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0)
            {
                txtTen.Text = "Bạn chưa nhập tên !";
                txtTen.Focus();
            }
            else
            {
                frmMovingMemory f = new frmMovingMemory(txtTen.Text);
               
                f.Show();
                this.Hide();
            }
        }

        private void rdoDe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDe.Checked)
            {
                frmMovingMemory.n = 16;
            }
        }

        private void rdoBThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBThuong.Checked)
            {
                frmMovingMemory.n = 20;
            }
        }

        private void rdoKho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKho.Checked)
            {
                frmMovingMemory.n = 24;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
