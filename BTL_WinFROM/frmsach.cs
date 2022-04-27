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
    public partial class frmsach : Form
    {
        public frmsach()
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
        public frmsach(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
        
        public void hienthi()
        {
            lv_ds.Items.Clear();
            ketnoi.Open();
            sql = @"select * from SACH";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_ds.Items.Add(docdl[0].ToString());
                lv_ds.Items[i].SubItems.Add(docdl[1].ToString());
                lv_ds.Items[i].SubItems.Add(docdl[2].ToString());
                lv_ds.Items[i].SubItems.Add(docdl[3].ToString());
                lv_ds.Items[i].SubItems.Add(docdl[4].ToString());
                i++;

            }
            ketnoi.Close();
        }

        private void frmsach_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ketnoiSQL);
            hienthi();
            if (leve == "2")
            {
                btn_them.Visible = false;
                btn_sua.Visible = false;
                btn_xoa.Visible = false;
            }
        }

        private void themsach(object sender, EventArgs e)
        {

        }

        private void chosach(object sender, EventArgs e)
        {
            txt_masach.Text = lv_ds.SelectedItems[0].SubItems[0].Text;
            txt_tensach.Text = lv_ds.SelectedItems[0].SubItems[1].Text;
            txt_tacgia.Text = lv_ds.SelectedItems[0].SubItems[2].Text;
            txt_theloai.Text = lv_ds.SelectedItems[0].SubItems[3].Text;
            txt_manhomsach.Text = lv_ds.SelectedItems[0].SubItems[4].Text;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            lv_ds.Items.Clear();
            ketnoi.Open();
            sql = @"Insert Into SACH(Ma_sach, Ten_sach, Tac_gia, The_loai, Ma_nhom_sach) values (N'" + txt_masach.Text + @"',
N'" + txt_tensach.Text + @"',N'" + txt_tacgia.Text + @"',N'" + txt_theloai.Text + @"',N'" + txt_manhomsach.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            lv_ds.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE SACH SET Ma_sach = N'" + txt_masach.Text + @"', Ten_sach =
N'" + txt_tensach.Text + @"',Tac_gia = N'" + txt_tacgia.Text + @"',The_loai = N'" + txt_theloai.Text + @"', Ma_nhom_sach = N'" +txt_manhomsach.Text + @"'
where (Ma_sach = N'" + txt_masach.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            lv_ds.Items.Clear();
            ketnoi.Open();
            sql = @"delete from SACH where (Ma_sach = N'" + txt_masach.Text + "')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.ShowDialog();
            
        }
    }
}
