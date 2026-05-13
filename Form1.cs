using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlisinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu người dùng nhập
            string emailNhap = txtEmail.Text;
            string matKhauNhap = txtMatKhau.Text;

            // Thay thế đoạn chữ trong ngoặc kép bằng Email sinh viên và MSSV thật của bạn
            string emailSinhVien = "0014768@st.huce.edu.vn";
            string mssvThiet = "123456";

            // Kiểm tra điều kiện
            if (emailNhap == emailSinhVien && matKhauNhap == mssvThiet)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
