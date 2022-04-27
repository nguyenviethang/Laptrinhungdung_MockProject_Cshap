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
    public partial class frmtksach : Form
        
    {
        public frmtksach()
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
        public frmtksach (string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
        private void frmtksach_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ketnoiSQL);
            hienthi();            
            
        }
        public void hienthi()
        {
            lv_htsach.Items.Clear();
            ketnoi.Open();
            sql = @"select * from SACH";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_htsach.Items.Add(docdl[0].ToString());
                lv_htsach.Items[i].SubItems.Add(docdl[1].ToString());
                lv_htsach.Items[i].SubItems.Add(docdl[2].ToString());
                lv_htsach.Items[i].SubItems.Add(docdl[3].ToString());
                lv_htsach.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }
        public void hienthi_tkma()
        {
            lv_httk.Items.Clear();
            ketnoi.Open();
            sql = @"select * from SACH where (Ma_sach = N'"+txt_masach.Text+@"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_httk.Items.Add(docdl[0].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[1].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[2].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[3].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }
        public void hienthi_tkten()
        {
            lv_httk.Items.Clear();
            ketnoi.Open();
            sql = @"select * from SACH where (Ten_sach = N'" + txt_tensach.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_httk.Items.Add(docdl[0].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[1].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[2].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[3].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }
        public void hienthi_tktl()
        {
            lv_httk.Items.Clear();
            ketnoi.Open();
            sql = @"select * from SACH where (The_loai = N'" + cmb_tktt.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_httk.Items.Add(docdl[0].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[1].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[2].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[3].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }
        public void hienthi_tk3()
        {
            lv_httk.Items.Clear();
            ketnoi.Open();
            sql = @"select * from SACH where (Ma_sach = N'"+txt_masach.Text+"' and Ten_sach = N'"+txt_tensach.Text+"' and The_loai = N'"+cmb_tktt.Text+"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_httk.Items.Add(docdl[0].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[1].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[2].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[3].ToString());
                lv_httk.Items[i].SubItems.Add(docdl[4].ToString());

                i++;

            }
            ketnoi.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_tksach_Click(object sender, EventArgs e)
        {
            if (txt_masach.Text != "")
                hienthi_tkma();
            if (txt_tensach.Text != "")
            {
                hienthi_tkten();
            }
            if (cmb_tktt.Text != "")
            {
                hienthi_tktl();
            }
            if (txt_masach.Text != "" && txt_tensach.Text != "" && cmb_tktt.Text != "")
                hienthi_tk3();
            if (txt_masach.Text == "" && txt_tensach.Text == "" && cmb_tktt.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Thông tin tìm kiếm", "Cảnh báo");
            }    
            ketnoi = new SqlConnection(ketnoiSQL);
            ketnoi.Close();
            
        }

        private void btn_xoaTK_Click(object sender, EventArgs e)
        {
            lv_httk.Items.Clear();
            txt_masach.Text = "";
            txt_tensach.Text = "";
            cmb_tktt.Text = "";
        }

        private void btn_thoattksach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.ShowDialog();
            this.Close();
        }
        
    }
}
