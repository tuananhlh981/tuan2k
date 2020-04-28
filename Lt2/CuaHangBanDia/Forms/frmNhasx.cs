using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanDia.Forms
{
    public partial class frmNhasx : Form
    {
        public frmNhasx()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtmansx.Text = "";
            txttennasx.Text = "";
            txtmansx.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)// nút thêm
        {
            Reset();
            txtmansx.Enabled = true;
            txtmansx.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmansx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã", "thông báo",MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtmansx.Focus();
                return;
            }

            if (txttennasx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txttennasx.Focus();
                return;
            }
            //--- 
            //sql = "INSERT INstring sql;
            string sql = "";
            sql = "SELECT mansx FROM noisanxuat WHERE mansx = N'" + txtmansx.Text.Trim() + "'";
           
            DataTable tblSX = ketnoi.Docbang(sql);
            if(tblSX.Rows.Count>0)
            {
                MessageBox.Show("Nhà sản xuất đã tồn tại", "Thông báo");
                txtmansx.Text = "";
                txttennasx.Text = "";
                txtmansx.Focus();
                return;
            }
            sql = "INSERT INTO noisanxuat(mansx,tennsx) Values(N'" + txtmansx.Text + "',N'" + txttennasx.Text + "')";
            ketnoi.Capnhat(sql);
            Hienthiluoi();
            //Reset();
       
        }
        private void Hienthiluoi()
        {
            string sql;
            DataTable tblsx;
            sql = "SELECT * FROM noisanxuat";
            tblsx = ketnoi.Docbang(sql);
            dtgvNhaSX.DataSource = tblsx;
            dtgvNhaSX.Columns[0].HeaderText = "Mã nhà sản xuất";
            dtgvNhaSX.Columns[1].HeaderText = "Tên nhà sản xuất";
            dtgvNhaSX.Columns[0].Width = 100;
            dtgvNhaSX.Columns[1].Width = 250;
            dtgvNhaSX.AllowUserToAddRows = false;
            dtgvNhaSX.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblsx.Dispose();
        }

        private void frmNhasx_Load(object sender, EventArgs e)
        {
            Hienthiluoi();
        }

        private void frmNhasx_Activated(object sender, EventArgs e)
        {
            Hienthiluoi();
        }
    }
}
