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
    public partial class fromhoadon : Form
    {
        public fromhoadon()
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
        public fromhoadon(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
        private void fromhoadon_Load(object sender, EventArgs e)
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
        public void hienthi()
        {
            lv_hd.Items.Clear();
            ketnoi.Open();
            sql = @"select * from HOA_DON";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_hd.Items.Add(docdl[0].ToString());
                lv_hd.Items[i].SubItems.Add(docdl[1].ToString());
                lv_hd.Items[i].SubItems.Add(docdl[2].ToString());
                lv_hd.Items[i].SubItems.Add(docdl[3].ToString());
                lv_hd.Items[i].SubItems.Add(docdl[4].ToString());
                lv_hd.Items[i].SubItems.Add(docdl[5].ToString());


                i++;

            }
            ketnoi.Close();
        }

        private void chonhd(object sender, EventArgs e)
        {
            txt_madh.Text = lv_hd.SelectedItems[0].SubItems[0].Text;
            txt_makh.Text = lv_hd.SelectedItems[0].SubItems[1].Text;
            txt_masach.Text = lv_hd.SelectedItems[0].SubItems[2].Text;
            txt_soluong.Text = lv_hd.SelectedItems[0].SubItems[3].Text;
            txt_ngaymuon.Text = lv_hd.SelectedItems[0].SubItems[4].Text;
            txt_ngaytra.Text = lv_hd.SelectedItems[0].SubItems[5].Text;
        }

        private void txt_ngaytra_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            lv_hd.Items.Clear();
            ketnoi.Open();
            sql = @"Insert Into HOA_DON(Ma_HD, Ma_KH, Ma_sach, So_luong, Ngay_muon, Ngay_tra) values (N'" + txt_madh.Text + @"',
N'" + txt_makh.Text + @"', N'" + txt_masach.Text + @"', N'" + txt_soluong.Text + @"', N'" + txt_ngaymuon.Text + @"', N'" + txt_ngaytra.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            lv_hd.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE HOA_DON SET Ma_HD = N'" +txt_madh.Text+@"', Ma_KH =
N'"+txt_makh.Text+@"', Ma_sach =
N'"+txt_masach.Text+@"', So_luong =
N'"+txt_soluong.Text+@"', Ngay_muon =
N'"+txt_ngaymuon.Text+@"',Ngay_tra =
N'"+txt_ngaytra.Text+@"'where (Ma_HD = N'" +txt_madh.Text+@"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            {
                lv_hd.Items.Clear();
                ketnoi.Open();
                sql = @"delete from HOA_DON where (Ma_HD = N'" + txt_madh.Text + "')";
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
