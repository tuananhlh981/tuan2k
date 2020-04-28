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
    public partial class frmKhodia : Form
    {
        public frmKhodia()
        {
            InitializeComponent();
        }
        DataTable tblkhodia;
        private void Load_DataGriview()

        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            //if (tblkhodia.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            if (cboMadia.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttendia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendia.Focus();
                return;
            }
            if (txtghichu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtghichu.Focus();
                return;
            }
            if (txtdongianhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongianhap.Focus();
                return;
            }
            if (cbomatheloai.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomatheloai.Focus();
                return;
            }
            if (cbomanhasanxuat.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanhasanxuat.Focus();
                return;
            }
            if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }
            if (txtdongiaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn gia bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongiaban.Focus();
                return;
            }
            sql = "SELECT * FROM khodia where madia=N'" + cboMadia.Text + "'";
            DataTable tbldia = ketnoi.Docbang(sql);
            if(tbldia.Rows.Count>0)
            {
                MessageBox.Show("Mã đĩa đã có", "Thông báo");
                return;
            }
            sql = "INSERT INTO khodia(madia, tendia, soluong, dongiaban,dongianhap,mansx,matheloai,ghichu) values(N'" + cboMadia.Text.Trim() + "',N'" + txttendia.Text.Trim() + "', N'" + txtsoluong.Text.Trim() + "',N'" + txtdongiaban.Text.Trim() + "',N'" + txtdongianhap.Text.Trim() + "',N'" + cbomanhasanxuat.Text.Trim() + "',N'" + cbomatheloai.Text.Trim() + "',N'" + txtghichu.Text.Trim() + "')";
            ketnoi.Capnhat(sql);
            sql = "";
            Hienthiluoi(sql);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            //if (tblkhodia.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            if (cboMadia.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttendia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendia.Focus();
                return;
            }
            if (txtghichu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtghichu.Focus();
                return;
            }
            if (txtdongianhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongianhap.Focus();
                return;
            }
            if (cbomatheloai.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomatheloai.Focus();
                return;
            }
            if (cbomanhasanxuat.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanhasanxuat.Focus();
                return;
            }
            if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }
            if (txtdongiaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn gia bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongiaban.Focus();
                return;
            }
            sql = "UPDATE tblKhodia SET tendia=N'"
                + txttendia.Text.Trim().ToString() + "',tendia=N'"
                + txtsoluong.Text.Trim().ToString() + "',soluong=N'"
                + cboMadia.SelectedValue.ToString() + "',madia=N'"
                + cbomanhasanxuat.SelectedValue.ToString() + "',mansx=N'"
                + cbomatheloai.SelectedValue.ToString() + "',matheloai=N'"
                + txtghichu.Text.Trim().ToString() + "',ghichu='"
                + txtdongianhap.Text.Trim().ToString() + "',dongianhap=N'"
                + txtdongiaban.Text.Trim().ToString() + "',dongiaban=N'";
            

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
           
            if(txtTimKiem.Text==""||cboTimKiem.Text=="")
            {
                MessageBox.Show("Không được để trống", "Thông báo");
                txtTimKiem.Focus();
                return;
            }
            //---
            string sql;
            if(cboTimKiem.Text.Contains("Nhà sản"))//
            {
                sql = "Select khodia.madia, tendia, soluong, dongiaban,dongianhap,khodia.mansx,khodia.matheloai,ghichu from khodia join noisanxuat on khodia.mansx=noisanxuat.mansx where noisanxuat.tennsx='" + txtTimKiem.Text.Trim()+"'";
                DataTable tblkd = ketnoi.Docbang(sql);
                int dem = 0;
                dem = tblkd.Rows.Count;
                MessageBox.Show("có :" + dem + " bản ghi được tìm thấy", "Thông báo");
             
                Hienthiluoi(sql);
            }
            else
            {
              
                sql = "Select khodia.madia, tendia, soluong, dongiaban,dongianhap,khodia.mansx,theloai.matheloai,ghichu from khodia join theloai on khodia.matheloai=theloai.matheloai where theloai.tentheloai='" + txtTimKiem.Text.Trim()+"'" ;          
                DataTable tblkd = ketnoi.Docbang(sql);
           
                int dem = 0;
                dem = tblkd.Rows.Count;
                MessageBox.Show("có :" + dem + " bản ghi được tìm thấy", "Thông báo");
                Hienthiluoi(sql);
            }

        }
        private void Hienthiluoi(string sql)
        {
           
            DataTable tblsx;
            if(sql=="")
            {
                sql = "SELECT * FROM khodia";
            }    
            
            tblsx = ketnoi.Docbang(sql);
            dtgvKhoDia.DataSource = tblsx;
            dtgvKhoDia.Columns[0].HeaderText = "Mã đĩa";
            dtgvKhoDia.Columns[1].HeaderText = "Tên đĩa";
            dtgvKhoDia.Columns[2].HeaderText = "Số lượng";
            dtgvKhoDia.Columns[3].HeaderText = "Giá bán";
            dtgvKhoDia.Columns[4].HeaderText = "Giá nhập";
            dtgvKhoDia.Columns[5].HeaderText = "Mã nhà sản xuất";
            dtgvKhoDia.Columns[6].HeaderText = "Mã thể loại";
            dtgvKhoDia.Columns[7].HeaderText = "Ghi chú";
            dtgvKhoDia.Columns[0].Width = 70;
            dtgvKhoDia.Columns[1].Width = 150;
            dtgvKhoDia.Columns[2].Width = 70;
            dtgvKhoDia.Columns[3].Width = 70;
            dtgvKhoDia.Columns[4].Width = 70;
            dtgvKhoDia.Columns[5].Width = 70;
            dtgvKhoDia.Columns[6].Width = 70;
            dtgvKhoDia.Columns[7].Width = 250;
            dtgvKhoDia.AllowUserToAddRows = false;
            dtgvKhoDia.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblsx.Dispose();
        }
        private void frmKhodia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "";
            Hienthiluoi(sql);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
