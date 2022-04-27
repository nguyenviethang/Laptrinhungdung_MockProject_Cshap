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
    public partial class frmhienthihan : Form
    {
        public frmhienthihan()
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

        public frmhienthihan(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
            private void frmhienthihan_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ketnoiSQL);
            hienthi();
        }
        public void hienthi()
        {
            lv_hansach.Items.Clear();
            ketnoi.Open();
            sql = @"select Ten_KH, Dia_chi, Ten_sach , The_loai, Ngay_muon, Ngay_tra ,day(getdate()) - day((Ngay_tra)) as N'Số Ngày Hết Hạn'
from HOA_DON join KHACH_HANG on HOA_DON.Ma_KH = KHACH_HANG.Ma_KH join SACH on SACH.Ma_sach = HOA_DON.Ma_sach
where  day(getdate()) - day((Ngay_tra)) > 0";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_hansach.Items.Add(docdl[0].ToString());
                lv_hansach.Items[i].SubItems.Add(docdl[1].ToString());
                lv_hansach.Items[i].SubItems.Add(docdl[2].ToString());
                lv_hansach.Items[i].SubItems.Add(docdl[3].ToString());
                lv_hansach.Items[i].SubItems.Add(docdl[4].ToString());
                lv_hansach.Items[i].SubItems.Add(docdl[5].ToString());
                lv_hansach.Items[i].SubItems.Add(docdl[6].ToString());
                i++;

            }
            ketnoi.Close();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtthoihan frm = new frmtthoihan(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.Show();
        }
    }
}
