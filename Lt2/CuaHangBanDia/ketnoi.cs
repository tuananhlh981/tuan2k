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
        public static SqlConnection conn;
        public static string conString = @"Data Source=DESKTOP-H29DLH4\SQLEXPRESS;Initial Catalog=quanlybandia;Integrated Security=True";
        public static void Ketnoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = conString;
            if(conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }    
        }
        public static void Dongketnoi()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static DataTable Docbang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Mydata = new SqlDataAdapter();
            Mydata.SelectCommand = new SqlCommand();
            Ketnoi();
            Mydata.SelectCommand.Connection = conn;
            Mydata.SelectCommand.CommandText = sql;
            Mydata.Fill(dt);
            Dongketnoi();
            return dt;
        }
        //private void Hienthi()
        //{
        //    string sql;
        //    DataTable tblQLD;
        //    sql
        //}
       // public static void thucthisql()
        public static void Capnhat(string sql)
        {
            Ketnoi();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            Dongketnoi();
        }
    }
}
