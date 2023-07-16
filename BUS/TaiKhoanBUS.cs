using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAO;

namespace BUS
{
    
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        public string checkLogin(TaiKhoanDTO tk)
        {
            if(tk.taiKhoan == "")
            {
                return "required_taikhoan";
            }
            if(tk.matKhau == "")
            {
                return "required_password";
            }

            string info = tkDAO.checkLogin(tk);
            return info;
        }
    }
}
