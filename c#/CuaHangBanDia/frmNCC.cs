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
    
    public partial class tblncc : Form
    {
        public tblncc()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void xoachu()
        {
            btnthem.Enabled = true;
            txtmancc.Enabled = true;

            txtmancc.ResetText();
            txtenncc.ResetText();
            txtsdt.ResetText();
            txtdiachi.ResetText();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text == "")
            {
                MessageBox.Show("ma nha cung cap k dc de trong");
            }
            else if (txtenncc.Text == "")
            {
                MessageBox.Show("ten khach hang k dc de trong");
            }
            else if (txtsdt.Text == "")
                MessageBox.Show("so dien thoai k dc de trong");
            else if (txtdiachi.Text == "")
                MessageBox.Show("dia chi k dc de trong");
            else
            {
                kn.add_ncc(txtmancc.Text, txtenncc.Text, txtdiachi.Text, txtsdt.Text);
                dgv_ncc.DataSource = kn.select_procdure("select_ncc");
                xoachu();
            }
        }

        private void tblncc_Load(object sender, EventArgs e)
        {
            dgv_ncc.DataSource = kn.select_procdure("select_ncc");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text == "")
            {
                MessageBox.Show("ma nha cung cap k dc de trong");
            }
            else if (txtenncc.Text == "")
            {
                MessageBox.Show("ten khach hang k dc de trong");
            }
            else if (txtsdt.Text == "")
                MessageBox.Show("so dien thoai k dc de trong");
            else if (txtdiachi.Text == "")
                MessageBox.Show("dia chi k dc de trong");
            else
            {
                kn.update_ncc(txtmancc.Text, txtenncc.Text, txtdiachi.Text, txtsdt.Text);
                dgv_ncc.DataSource = kn.select_procdure("select_ncc");
                xoachu();
            }
        }

        private void dgv_ncc_Click(object sender, EventArgs e)
        {
            int r = dgv_ncc.CurrentCell.RowIndex;
            btnthem.Enabled = false;
            txtmancc.Enabled = false;
            txtmancc.Text = dgv_ncc.Rows[r].Cells["mncc"].Value.ToString(); /* makh la name cua truong dl trong dgv gan vao txtmakhachhang*/
            txtenncc.Text = dgv_ncc.Rows[r].Cells["tncc"].Value.ToString();
            txtsdt.Text = dgv_ncc.Rows[r].Cells["dt"].Value.ToString();
            txtdiachi.Text = dgv_ncc.Rows[r].Cells["dc"].Value.ToString();
         
        }   

        private void tblncc_MouseClick(object sender, MouseEventArgs e)
        {
            btnthem.Enabled = true;
            txtmancc.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("bạn có muốn xóa khach hang  không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    kn.truyvan("delete from nhacungcap where mancc='" + txtmancc.Text + "'");
                    dgv_ncc.DataSource = kn.truyvan("select * from nhacungcap");
                    xoachu();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.search_ncc(txtmancc.Text, txtenncc.Text, txtdiachi.Text, txtsdt.Text);
            dgv_ncc.DataSource = dt;
        }
    }
}
