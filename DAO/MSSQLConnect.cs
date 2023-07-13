using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=LAPTOP-AEI9M0MI\\WIZARDSC;Initial Catalog=QuanLySinhVienC#;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    
    public class MSSQLConnect
    {
        
    }
}
