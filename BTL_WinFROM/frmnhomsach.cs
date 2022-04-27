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
    public partial class frmnhomsach : Form
    {
        public frmnhomsach()
        {
            InitializeComponent();
        }
        string idtaikhoan = "", taikhoan = "", matkhau = "", leve = "";
        string ketnoiSQL = @"Data Source=DESKTOP-V7K1NAA\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdl;
        int i = 0;
        public frmnhomsach(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
        private void frmnhomsach_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ketnoiSQL);
            hienthi();
            if (leve == "2")
            {
                btn_them.Visible = false;
                btn_sua.Visible = false;
                btn_xoa.Visible = false;
            }
            // btn_them.Visible = false;
        }
        public void hienthi()
        {
            vl_ls.Items.Clear();
            ketnoi.Open();
            sql = @"select * from LOAI_SACH";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                vl_ls.Items.Add(docdl[0].ToString());
                vl_ls.Items[i].SubItems.Add(docdl[1].ToString());
                i++;

            }
            ketnoi.Close();
        }

        private void chonnhomsach(object sender, EventArgs e)
        {
            txtmans.Text = vl_ls.SelectedItems[0].SubItems[0].Text;
            txttenns.Text = vl_ls.SelectedItems[0].SubItems[1].Text;
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            vl_ls.Items.Clear();
            ketnoi.Open();
            sql = @"Insert Into LOAI_SACH(Ma_nhom_sach, Ten_nhom_sach) values (N'" + txtmans.Text + @"',
N'" + txttenns.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            vl_ls.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE LOAI_SACH SET Ma_nhom_sach = N'" + txtmans.Text + @"', Ten_nhom_sach =
N'" + txttenns.Text + @"'where (Ma_nhom_sach = N'" + txtmans.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            {
                vl_ls.Items.Clear();
                ketnoi.Open();
                sql = @"delete from LOAI_SACH where (Ma_nhom_sach = N'" + txtmans.Text + "')";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
                hienthi();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.ShowDialog();
            this.Close();
        }
    }
}
