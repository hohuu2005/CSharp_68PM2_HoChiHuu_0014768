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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void quảnLíLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pnlNoiDung.Controls.Clear();

            frmLopHoc frm = new frmLopHoc();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void quảnLíSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
             pnlNoiDung.Controls.Clear();
            frmSinhVien frmSV = new frmSinhVien();
            frmSV.TopLevel = false;
            frmSV.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(frmSV);
            frmSV.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            frmSinhVien frmSV = new frmSinhVien();
            frmSV.TopLevel = false;
            frmSV.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(frmSV);
            frmSV.Show();
        }
    }
}
