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

namespace BTL_WinFROM
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void cltk(object sender, EventArgs e)
        {
            txt_taikhoan.Text = "";
        }

        private void clmk(object sender, EventArgs e)
        {
            txt_matkhau.Text = "";
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            
            dangnhap();
            
        }
        public void dangnhap()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-V7K1NAA\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN where tai_khoan = N'"+txt_taikhoan.Text+"' and matkhau = N'"+txt_matkhau.Text+"'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                 // string tkk = taikhoan;
             
                
                if (dt.Rows[0][3].ToString() == "1")
                {
                    //    tkk = txttkng.Text;
                    MessageBox.Show("Xin Chào " + dt.Rows[0][1].ToString(), "WelCome");

                    //     MessageBox.Show("ten bạn la admin", "thong bao");
                }
                if (dt.Rows[0][3].ToString() != "1")
                {
                    MessageBox.Show("Xin Chào " + dt.Rows[0][1].ToString(), "WelCome");
                }
                this.Hide();
                Form1 frm = new Form1(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                // frmtksach1.ShowDialog();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("bạn nhạp sai thông tin tài khoản mật khẩu");
            }
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
