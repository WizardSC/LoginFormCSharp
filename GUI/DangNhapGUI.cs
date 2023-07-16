using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;

namespace GUI
{
    public partial class DangNhapGUI : Form

    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();  
        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void DangNhapGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            taikhoan.taiKhoan = txtTenDangNhap.Text;
            taikhoan.matKhau = txtMatKhau.Text;
            string getuser = tkBUS.checkLogin(taikhoan);
            switch (getuser)
            {
                //    case "a":
                //        messagebox.show("không được để trống");
                //    case "required_password":
                //        messagebox.show("không được để trống");
                case "Tài khoản hoặc mật khẩu không chính xác":
                    MessageBox.Show("Sai tên TK/ Mật khẩu");
                    return;

            }
            MessageBox.Show("Đăng nhập thành công");
        }
    }
}
