using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanDia
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void khoĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmKhodia f = new Forms.frmKhodia();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhanvien f = new Forms.frmNhanvien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhasx f = new Forms.frmNhasx();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTheloai f = new Forms.frmTheloai();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
