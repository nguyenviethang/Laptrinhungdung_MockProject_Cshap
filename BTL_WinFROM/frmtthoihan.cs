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
    public partial class frmtthoihan : Form
    {
        public frmtthoihan()
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
        public frmtthoihan(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
        private void frmtthoihan_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ketnoiSQL);
            hienthi();
        }
        public void hienthi()
        {
            lv_muon.Items.Clear();
            ketnoi.Open();
            sql = @"select Ten_KH, Dia_chi, Ten_sach, The_loai, Ngay_muon, Ngay_tra from HOA_DON join KHACH_HANG on HOA_DON.Ma_KH = KHACH_HANG.Ma_KH join SACH on SACH.Ma_sach = HOA_DON.Ma_sach
";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_muon.Items.Add(docdl[0].ToString());
                lv_muon.Items[i].SubItems.Add(docdl[1].ToString());
                lv_muon.Items[i].SubItems.Add(docdl[2].ToString());
                lv_muon.Items[i].SubItems.Add(docdl[3].ToString());
                lv_muon.Items[i].SubItems.Add(docdl[4].ToString());
                lv_muon.Items[i].SubItems.Add(docdl[5].ToString());

                i++;

            }
            ketnoi.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            //   DialogResult f = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //   if (f == DialogResult.Yes)
            //  {
            // Form1 frm = new Form1();
            // frm.Show();
            this.Hide();
            Form1 frm = new Form1(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.ShowDialog();
            this.Close();
            //  }
        }

        private void btn_dshan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmhienthihan frm = new frmhienthihan(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.Show();
        }

        private void lv_muon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
