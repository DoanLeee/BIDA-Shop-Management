using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO4
{
    public partial class frm_DangNhap : Form
    {
        int dem;
        public static class mystring
        {
            public static string taikhoan;
            public static string matkhau;
        }
        
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        ClassChung lopchung = new ClassChung();

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

            string sql = "select count (*) from TAIKHOAN where TenTaiKhoan = '" + txt_TenTaiKhoan.Text + "'AND MatKhau ='" + txt_MatKhau.Text + "'";
            int kq = (int)lopchung.Scalar(sql);

            if (txt_TenTaiKhoan.Text.ToLower() == "admin" && txt_MatKhau.Text.ToLower() == "12345")
            {
                MessageBox.Show("Đăng nhập thành công !");

            }
            else
            if (kq >= 1)
            {
                mystring.taikhoan = txt_TenTaiKhoan.Text;
                mystring.matkhau = txt_MatKhau.Text;

                frm_Main Main = new frm_Main();
                Main.Show();
                MessageBox.Show("Đăng nhập thành công !");

            }
            else
            {
                dem++;
                if (dem < 3)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dem == 3)
                {
                    MessageBox.Show("Đăng nhập thất bại !! \r\n Bạn đã sai 3 lần !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

        }

        private void cb_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienMatKhau.Checked == true)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else txt_MatKhau.UseSystemPasswordChar = true;

        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txt_TenTaiKhoan.Text = "Ngphtai";
            txt_MatKhau.Text = "12345";

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Lấy chiều rộng và chiều cao của form
            int formWidth = this.Width;
            int formHeight = this.Height;

            // Tính toán vị trí mới cho form
            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            // Đặt vị trí mới cho form
            this.SetDesktopLocation(left, top);
        }

 


    }
}
