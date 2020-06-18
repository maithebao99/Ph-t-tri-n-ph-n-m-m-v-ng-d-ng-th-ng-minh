using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QLThuVien
{
    public partial class frmMain : Form
    {
        string username, password;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string user, string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
        }
        // BackUp

      

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form login = new frmDangNhap();
                login.ShowDialog();
            }
            else if (dialog == DialogResult.No)
            {
                
            }
        }
        
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("xin chào: " + username);
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form GT = new frmGioiThieu();
            GT.ShowDialog();
        }
        
        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GT = new frmGioiThieu();
            GT.ShowDialog();
        }

        //BackUp
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        //Restore
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NguoiDung = new frmNguoiDung(username, password);
            NguoiDung.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form login = new frmDangNhap();
                login.ShowDialog();
            }
            else if (dialog == DialogResult.No)
            {
                //
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form NguoiDung = new frmNguoiDung(username, password);
            NguoiDung.ShowDialog();
        }


        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Form GT = new frmGioiThieu();
            GT.ShowDialog();
        }

       
    }
}
