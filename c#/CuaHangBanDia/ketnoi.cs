using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CuaHangBanDia
{
    class ketnoi
    {
        public static string strketnoi = @"Data Source=DESKTOP-04RROGQ\SQLEXPRESS01;Initial Catalog = quanlycuahangbangdia; Integrated Security = True";

        SqlConnection con;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommand cmd;

        public SqlConnection open()
        {
            con = new SqlConnection(strketnoi);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public SqlConnection close()
        {
            con = new SqlConnection(strketnoi);
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }

        public DataTable truyvan(string sql)
        {
            open();
            dt = new DataTable();
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }

        public DataTable select_procdure(string tenprocedure)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand(tenprocedure, con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }

        public SqlCommand add_kh(string Makh  , string Tenkh, string sdt, string diachi)
        {
            open();
            cmd = new SqlCommand("add_kh", con);
            cmd.Parameters.Add(new SqlParameter("@makhach", Makh));
            cmd.Parameters.Add(new SqlParameter("@tenkhach", Tenkh));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", sdt));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }

        public SqlCommand update_kh(string Makh, string Tenkh, string sdt, string diachi)
        {
            open();
            cmd = new SqlCommand("update_kh", con);
            cmd.Parameters.Add(new SqlParameter("@makhach", Makh)); /*@makhach phai giong trong db khai bao*/
            cmd.Parameters.Add(new SqlParameter("@tenkhach", Tenkh));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", sdt));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        /*loi chuc nang tim kiem*/
        public DataTable search_kh(string Makh, string Tenkh, string sdt, string diachi)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand("search_kh", con);
            cmd.Parameters.Add(new SqlParameter("@makhach", Makh)); /*@makhach phai giong trong db khai bao*/
            cmd.Parameters.Add(new SqlParameter("@tenkhach", Tenkh));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", sdt));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }




        public DataTable search_ncc(string Mancc, string Tenncc, string diachi, string dienthoai)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand("search_ncc", con);
            cmd.Parameters.Add(new SqlParameter("@mancc", Mancc));
            cmd.Parameters.Add(new SqlParameter("@tenncc", Tenncc));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }

        /////////////////////
        public SqlCommand add_ncc(string Mancc, string Tenncc, string diachi, string dienthoai)
        {
            open();
            cmd = new SqlCommand("add_ncc", con);
            cmd.Parameters.Add(new SqlParameter("@mancc", Mancc));
            cmd.Parameters.Add(new SqlParameter("@tenncc", Tenncc));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        /////////////////////

        public SqlCommand add_ks(string MaKS, string MaTour, string TenKS, float GiaPhong, string DiaChi, string Dienthoai)
        {
            open();
            cmd = new SqlCommand("add_ks", con);
            cmd.Parameters.Add(new SqlParameter("@MaKS", MaKS));
            cmd.Parameters.Add(new SqlParameter("@MaTour", MaTour));
            cmd.Parameters.Add(new SqlParameter("@TenKS", TenKS));
            cmd.Parameters.Add(new SqlParameter("@GiaPhong", GiaPhong));
            cmd.Parameters.Add(new SqlParameter("@Diachi", DiaChi));
            cmd.Parameters.Add(new SqlParameter("@Dienthoai", Dienthoai));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }

        public SqlCommand update_ncc(string Mancc, string Tenncc, string diachi, string dienthoai)
        {
            open();
            cmd = new SqlCommand("update_ncc", con);
            cmd.Parameters.Add(new SqlParameter("@mancc", Mancc));
            cmd.Parameters.Add(new SqlParameter("@tenncc", Tenncc));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        //////
        public SqlCommand add_pt(string MaPT, string MaTour, string TenPT, string HienTrang, float SucChua)
        {
            open();
            cmd = new SqlCommand("add_pt", con);
            cmd.Parameters.Add(new SqlParameter("@MaPT", MaPT));
            cmd.Parameters.Add(new SqlParameter("@MaTour", MaTour));
            cmd.Parameters.Add(new SqlParameter("@TenPT", TenPT));
            cmd.Parameters.Add(new SqlParameter("@HienTrang", HienTrang));
            cmd.Parameters.Add(new SqlParameter("@SucChua", SucChua));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }



    }
}
