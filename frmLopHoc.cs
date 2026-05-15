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
    public partial class frmLopHoc : Form
    {
        DataTable bangLopHoc = new DataTable();

        public void frmLopHoc_Load(object sender, EventArgs e)
        {
            bangLopHoc.Columns.Add("Mã ID");
            bangLopHoc.Columns.Add("Mã lớP học");
            bangLopHoc.Columns.Add("Tên lớp học");
            bangLopHoc.Columns.Add("ghi chú");

            bangLopHoc.Rows.Add("1", "CTK43", "Công nghệ thông tin K43", "Lớp học công nghệ thông tin khóa 43");
            bangLopHoc.Rows.Add("2", "CTK44", "Công nghệ thông tin K44", "Lớp học công nghệ thông tin khóa 44");
            //banglopHoc.Rows.Add("2", "CTK44", "Công nghệ thông tin K44", "Lớp học công nghệ thông tin khóa 44");
            bangLopHoc.Rows.Add("3", "CTK45", "Công nghệ thông tin K45", "Lớp học công nghệ thông tin khóa 45");
            dgvLopHoc.DataSource = bangLopHoc;
        }
        public frmLopHoc()
        {
            InitializeComponent();
        }

       // private void frmLopHoc_Load(object sender, EventArgs e)
        //

       // }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
