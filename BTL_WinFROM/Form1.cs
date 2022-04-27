using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WinFROM
{
    public partial class Form1 : Form
    {
        string idtaikhoan = "", taikhoan = "", matkhau = "", leve = "";
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void QLDG(object sender, EventArgs e)
        {
            this.Hide();
            frmnguoidung frm = new frmnguoidung(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.ShowDialog();
            
        }

        private void QLSach(object sender, EventArgs e)
        {
            this.Hide();
            frmsach frm = new frmsach(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         /* // string tkk = taikhoan;
            if(leve == "1")
            {
                //    tkk = txttkng.Text;
                   MessageBox.Show("Xin Chào " + taikhoan.ToString(), "WelCome");
                
           //     MessageBox.Show("ten bạn la admin", "thong bao");
            }
            if(leve != "1")
            {
                MessageBox.Show("Xin Chào " + taikhoan.ToString(), "WelCome");
            }*/
        }

        private void qlnhomsach(object sender, EventArgs e)
        {
            
            frmnhomsach frm = new frmnhomsach(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.Show();
            this.Hide();
        }

        private void chonhd(object sender, EventArgs e)
        {
            this.Hide();
            fromhoadon from = new fromhoadon(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            from.Show();
            
        }

        private void tksach(object sender, EventArgs e)
        {

            this.Hide();
            frmtksach frm = new frmtksach( idtaikhoan.ToString(), taikhoan.ToString(),matkhau.ToString(),leve.ToString());
            frm.Show();
            
        }

        private void btn_dx_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdangnhap frm = new frmdangnhap();
            frm.Show();
        }

        private void tknguoidung(object sender, EventArgs e)
        {
            this.Hide();
            frmtkdg frm = new frmtkdg(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.Show();
            
        }

        private void tksachtv(object sender, EventArgs e)
        {
            this.Hide();
            fromthongke frm = new fromthongke(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.Show();
            
        }

        private void thốngKêNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtthoihan frm = new frmtthoihan(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.Show();
            
        }
    }
}
