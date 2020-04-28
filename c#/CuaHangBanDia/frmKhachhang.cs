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
    public partial class tblkhachhang : Form
    {

        ketnoi kn = new ketnoi();
        public tblkhachhang()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "")
            {
                MessageBox.Show("ma khach hang k dc de trong");
            }
            else if (txttenkhachhang.Text == "")
            {
                MessageBox.Show("ten khach hang k dc de trong");
            }
            else if (txtsdt.Text == "")
                MessageBox.Show("so dien thoai k dc de trong");
            else if (txtdiachi.Text == "")
                MessageBox.Show("dia chi k dc de trong");
            else
            {
                kn.add_kh(txtmakhachhang.Text,txttenkhachhang.Text,txtsdt.Text,txtdiachi.Text);
                dgv_khachhang.DataSource = kn.select_procdure("select_kh");
                xoachu();
            }
        }


        private void xoachu()
        {
            btnthem.Enabled = true;
            txtmakhachhang.Enabled = true;

            txtmakhachhang.ResetText();
            txttenkhachhang.ResetText();
            txtsdt.ResetText();
           txtdiachi.ResetText();
            
        }

        private void tblkhachhang_Load(object sender, EventArgs e) /*khi goi form khachhang*/
        {
            dgv_khachhang.DataSource = kn.select_procdure("select_kh");
        }

        

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text == "")
            {
                MessageBox.Show("ma khach hang k dc de trong");
            }
            else if (txttenkhachhang.Text == "")
            {
                MessageBox.Show("ten khach hang k dc de trong");
            }
            else if (txtsdt.Text == "")
                MessageBox.Show("so dien thoai k dc de trong");
            else if (txtdiachi.Text == "")
                MessageBox.Show("dia chi k dc de trong");
            else
            {
                kn.update_kh(txtmakhachhang.Text, txttenkhachhang.Text, txtsdt.Text, txtdiachi.Text);
                dgv_khachhang.DataSource = kn.select_procdure("select_kh");
                xoachu();
            }
        }
        /*sua*/
        private void dgv_khachhang_Click(object sender, EventArgs e)
        {
            int r = dgv_khachhang.CurrentCell.RowIndex;
            btnthem.Enabled = false;
            txtmakhachhang.Enabled = false;
            txtmakhachhang.Text = dgv_khachhang.Rows[r].Cells["makh"].Value.ToString(); /* makh la name cua truong dl trong dgv gan vao txtmakhachhang*/
            txttenkhachhang.Text = dgv_khachhang.Rows[r].Cells["tenkh"].Value.ToString();
            txtsdt.Text = dgv_khachhang.Rows[r].Cells["dt"].Value.ToString();
            txtdiachi.Text = dgv_khachhang.Rows[r].Cells["dc"].Value.ToString();
        }

        private void tblkhachhang_Click(object sender, EventArgs e)
        {

        }

        private void tblkhachhang_MouseClick(object sender, MouseEventArgs e)
        {
            btnthem.Enabled = true;
            txtmakhachhang.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmakhachhang.Text != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("bạn có muốn xóa khach hang  không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    kn.truyvan("delete from khachhang where makhach='" + txtmakhachhang.Text + "'");
                    dgv_khachhang.DataSource = kn.truyvan("select * from khachhang");
                    xoachu();
                }
            }
        }
        /* loi chuc nang tim kiem*/
        private void btntim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.search_kh(txtmakhachhang.Text, txttenkhachhang.Text, txtsdt.Text, txtdiachi.Text);
            dgv_khachhang.DataSource = dt;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*sua*/
    }
}
