using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=LAPTOP-AEI9M0MI\WIZARDSC;Initial Catalog=QuanLySinhVienC#;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLogin(TaiKhoanDTO taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("sp_DSTaiKhoan", conn); //procedure dùng để lấy ds tài khoản
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@MaTK", taikhoan.maTK);
            command.Parameters.AddWithValue("@TenTK", taikhoan.taiKhoan);
            command.Parameters.AddWithValue("@MatKhau", taikhoan.matKhau);
            //command.Parameters.AddWithValue("@Quyen", taikhoan.quyen);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác";
            }
            return user;
        }
    }
    
}
