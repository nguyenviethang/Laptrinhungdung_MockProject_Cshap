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
    public partial class frmtkdg : Form
    {
        public frmtkdg()
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
        public frmtkdg(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
        private void frmtkdg_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ketnoiSQL);
            hienthi();

        }
        public void hienthi()
        {
            lv_htkh.Items.Clear();
            ketnoi.Open();
            sql = @"select * from KHACH_HANG";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_htkh.Items.Add(docdl[0].ToString());
                lv_htkh.Items[i].SubItems.Add(docdl[1].ToString());
                lv_htkh.Items[i].SubItems.Add(docdl[2].ToString());
                lv_htkh.Items[i].SubItems.Add(docdl[3].ToString());
                lv_htkh.Items[i].SubItems.Add(docdl[4].ToString());

                i++;
            }
            ketnoi.Close();
        }
        public void hienthi_tkma()
        {
            lv_tkkh.Items.Clear();
            ketnoi.Open();
            sql = @"select * from KHACH_HANG where (Ma_KH = N'" + txt_makh.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_tkkh.Items.Add(docdl[0].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[1].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[2].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[3].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }
        public void hienthi_tkten()
        {
            lv_tkkh.Items.Clear();
            ketnoi.Open();
            sql = @"select * from KHACH_HANG where (Ten_KH = N'" + txt_tenKH.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_tkkh.Items.Add(docdl[0].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[1].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[2].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[3].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }
        public void hienthi_tktl()
        {
            lv_tkkh.Items.Clear();
            ketnoi.Open();
            sql = @"select * from KHACH_HANG where (Dia_chi = N'" + txt_diachi.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_tkkh.Items.Add(docdl[0].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[1].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[2].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[3].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }
        public void hienthi_tk3()
        {
            lv_tkkh.Items.Clear();
            ketnoi.Open();
            sql = @"select * from KHACH_HANG where (Ma_KH = N'" + txt_makh.Text + "' and Ten_KH = N'" + txt_tenKH.Text + "' and Dia_chi = N'" + txt_diachi.Text + "')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_tkkh.Items.Add(docdl[0].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[1].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[2].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[3].ToString());
                lv_tkkh.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }

        private void btn_Tkkh_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "")
                hienthi_tkma();
            if (txt_tenKH.Text != "")
            {
                hienthi_tkten();
            }
            if (txt_diachi.Text != "")
            {
                hienthi_tktl();
            }
            if (txt_makh.Text != "" && txt_tenKH.Text != "" && txt_diachi.Text != "")
                hienthi_tk3();
            if (txt_makh.Text == "" && txt_tenKH.Text == "" && txt_diachi.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Thông tin tìm kiếm", "Cảnh báo");
            }
            ketnoi = new SqlConnection(ketnoiSQL);
            ketnoi.Close();
        }

        private void btn_xoatkkh_Click(object sender, EventArgs e)
        {
            lv_tkkh.Items.Clear();
            txt_makh.Text = "";
            txt_tenKH.Text = "";
            txt_diachi.Text = "";
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
