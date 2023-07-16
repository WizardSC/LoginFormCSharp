using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAO
{
    public class TaiKhoanDAO:DatabaseAccess
    {
        public string checkLogin(TaiKhoanDTO tk)
        {
            string info = CheckLogin(tk);
            return info;
        }
    }
}
