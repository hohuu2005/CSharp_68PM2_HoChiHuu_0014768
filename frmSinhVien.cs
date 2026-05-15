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
    public partial class frmSinhVien : Form
    {
        DataTable bangSinhVien = new DataTable();
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            bangSinhVien.Columns.Add("Mã SV");
            bangSinhVien.Columns.Add("Họ tên");

            bangSinhVien.Columns.Add("Giới tính");
            bangSinhVien.Columns.Add("Ngày sinh");
            bangSinhVien.Columns.Add("Lớp học");

            bangSinhVien.Rows.Add("0014768", "Nguyễn Văn A", "Nam", "01/01/2000", "CTK43");
            bangSinhVien.Rows.Add("0014769", "Trần Thị B", "Nữ", "02/02/2000", "CTK44");
            bangSinhVien.Rows.Add("0014770", "Lê Văn C", "Nam", "03/03/2000", "CTK45");

            dgvSinhVien.DataSource = bangSinhVien;

            cboLop.Items.Add("68PM2- lớp 68pm2");
            cboLop.Items.Add("68Pm1 - lớp 68pm1");
            cboLop.SelectedIndex = 0;
        }
    }
}
