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
    public partial class fromthongke : Form
    {
        public fromthongke()
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
        public fromthongke(string idtaikhoan, string taikhoan, string matkhau, string leve)
        {
            InitializeComponent();
            this.idtaikhoan = idtaikhoan;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.leve = leve;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fromthongke_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(ketnoiSQL);
            hienthi();
            hienthi2();
            hienthi3();
        }
        public void hienthi()
        {
            lv_sachcon.Items.Clear();
            ketnoi.Open();
            sql = @"select SACH.Ten_sach, SACH.Tac_gia, SACH.The_loai from SACH
except
select SACH.Ten_sach, SACH.Tac_gia, SACH.The_loai from HOA_DON join SACH on HOA_DON.Ma_sach = SACH.Ma_sach
";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_sachcon.Items.Add(docdl[0].ToString());
                lv_sachcon.Items[i].SubItems.Add(docdl[1].ToString());
                lv_sachcon.Items[i].SubItems.Add(docdl[2].ToString());
                i++;

            }
            ketnoi.Close();
        }
        public void hienthi2()
        {
            lv_sachconnhom.Items.Clear();
            ketnoi.Open();
            sql = @"select * from qlsach1";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_sachconnhom.Items.Add(docdl[0].ToString());
                lv_sachconnhom.Items[i].SubItems.Add(docdl[1].ToString());
                i++;

            }
            ketnoi.Close();
        }
        public void hienthi3()
        {

            lv_slcon.Items.Clear();
            ketnoi.Open();
            sql = @"select  COUNT(Ma_sach) as N'Số Lượng Sách Hiện Có'  from qlsach";
            thuchien = new SqlCommand(sql, ketnoi);
            docdl = thuchien.ExecuteReader();
            i = 0;
            while (docdl.Read())
            {
                lv_slcon.Items.Add(docdl[0].ToString());
                i++;

            }
            ketnoi.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1(idtaikhoan.ToString(), taikhoan.ToString(), matkhau.ToString(), leve.ToString());
            frm.ShowDialog();
            //this.Close();
        }
    }
}
