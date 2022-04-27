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
    public partial class frmnguoidung : Form
    {
        public frmnguoidung()
        {
            InitializeComponent();
        }
        string ldl1;
        string idtaikhoan = "", taikhoan = "", matkhau = "", leve = "";
        string ketnoiSQL = @"Data Source=DESKTOP-V7K1NAA\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdl;
        int i = 0;
        public frmnguoidung(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
     //       this.ldl1 = ldl1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE KHACH_HANG SET Ma_KH = N'" + txt_madg.Text + @"', Ten_KH =
N'" + txt_tendg.Text + @"',Dia_chi = N'" + txt_diachi.Text + @"',SDT = N'" + txt_sdt.Text + @"',Email = N'" + txt_email.Text + @"'
where (Ma_KH = N'" + txt_madg.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.ShowDialog();
            this.Close();
        }

        private void frmnguoidung_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ketnoiSQL);
            //checkma();
            hienthi();
            if(leve == "2")
            {
                btn_them.Visible = false;
                btn_sua.Visible = false;
                btn_xoa.Visible = false;
            }
        }
        public void hienthi()
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"select * from KHACH_HANG";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                listView1.Items.Add(docdl[0].ToString());
                listView1.Items[i].SubItems.Add(docdl[1].ToString());
                listView1.Items[i].SubItems.Add(docdl[2].ToString());
                listView1.Items[i].SubItems.Add(docdl[3].ToString());
                listView1.Items[i].SubItems.Add(docdl[4].ToString());
                i++;
                
            }
            


            ketnoi.Close();
        }
        public void checkma()
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"select Ma_KH from KHACH_HANG where (Ma_KH = N'" + txt_madg.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            MessageBox.Show("trung mã ");
            ketnoi.Close();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txt_madg.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txt_tendg.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txt_diachi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txt_sdt.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txt_email.Text = listView1.SelectedItems[0].SubItems[4].Text;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           /* ldl1 = listView1.Items[i].SubItems[0].Text;
            i++;*/
            if (txt_madg.Text == ""  || txt_tendg.Text=="" || txt_diachi.Text=="" || txt_sdt.Text=="" || txt_email.Text == "")
            {
                MessageBox.Show("Bạn Nhập Hãy Nhập Đầy Đủ Thông tin");
            }
            else if(txt_madg.Text != "")
            {
                checkma();
            }
            /*else
            {

                listView1.Items.Clear();
                ketnoi.Open();
                sql = @"Insert Into KHACH_HANG(Ma_KH, Ten_KH, Dia_Chi, SDT, Email) values (N'" + txt_madg.Text + @"',
N'" + txt_tendg.Text + @"',N'" + txt_diachi.Text + @"',N'" + txt_sdt.Text + @"',N'" + txt_email.Text + @"')";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
                hienthi();
            }*/

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"delete from KHACH_HANG where (Ma_KH = N'" + txt_madg.Text + "')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
       //     hienthi();
        }
    }
}
