namespace BTL_WinFROM
{
    partial class frmtksach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoaTK = new System.Windows.Forms.Button();
            this.cmb_tktt = new System.Windows.Forms.ComboBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.btn_thoattksach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.btn_tksach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_httk = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_htsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_X = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoaTK);
            this.groupBox1.Controls.Add(this.cmb_tktt);
            this.groupBox1.Controls.Add(this.txt_tensach);
            this.groupBox1.Controls.Add(this.btn_thoattksach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_masach);
            this.groupBox1.Controls.Add(this.btn_tksach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(84, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_xoaTK
            // 
            this.btn_xoaTK.Location = new System.Drawing.Point(286, 85);
            this.btn_xoaTK.Name = "btn_xoaTK";
            this.btn_xoaTK.Size = new System.Drawing.Size(82, 30);
            this.btn_xoaTK.TabIndex = 8;
            this.btn_xoaTK.Text = "Xóa TK";
            this.btn_xoaTK.UseVisualStyleBackColor = true;
            this.btn_xoaTK.Click += new System.EventHandler(this.btn_xoaTK_Click);
            // 
            // cmb_tktt
            // 
            this.cmb_tktt.FormattingEnabled = true;
            this.cmb_tktt.Items.AddRange(new object[] {
            "SGK",
            "Truyện tranh",
            "Kỹ năng sống"});
            this.cmb_tktt.Location = new System.Drawing.Point(503, 42);
            this.cmb_tktt.Name = "cmb_tktt";
            this.cmb_tktt.Size = new System.Drawing.Size(121, 21);
            this.cmb_tktt.TabIndex = 7;
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(276, 43);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(145, 20);
            this.txt_tensach.TabIndex = 6;
            // 
            // btn_thoattksach
            // 
            this.btn_thoattksach.Location = new System.Drawing.Point(451, 85);
            this.btn_thoattksach.Name = "btn_thoattksach";
            this.btn_thoattksach.Size = new System.Drawing.Size(82, 30);
            this.btn_thoattksach.TabIndex = 5;
            this.btn_thoattksach.Text = "Thoát";
            this.btn_thoattksach.UseVisualStyleBackColor = true;
            this.btn_thoattksach.Click += new System.EventHandler(this.btn_thoattksach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Sách";
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(82, 43);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(100, 20);
            this.txt_masach.TabIndex = 2;
            // 
            // btn_tksach
            // 
            this.btn_tksach.Location = new System.Drawing.Point(114, 83);
            this.btn_tksach.Name = "btn_tksach";
            this.btn_tksach.Size = new System.Drawing.Size(90, 32);
            this.btn_tksach.TabIndex = 1;
            this.btn_tksach.Text = "Tìm Kiếm";
            this.btn_tksach.UseVisualStyleBackColor = true;
            this.btn_tksach.Click += new System.EventHandler(this.btn_tksach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_httk);
            this.groupBox2.Location = new System.Drawing.Point(84, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tìm kiếm";
            // 
            // lv_httk
            // 
            this.lv_httk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lv_httk.HideSelection = false;
            this.lv_httk.Location = new System.Drawing.Point(6, 19);
            this.lv_httk.Name = "lv_httk";
            this.lv_httk.Size = new System.Drawing.Size(618, 90);
            this.lv_httk.TabIndex = 2;
            this.lv_httk.UseCompatibleStateImageBehavior = false;
            this.lv_httk.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = " Mã Sách";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên Sách";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tác Giả";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Thể loại";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã Nhóm Sách";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_htsach);
            this.groupBox3.Location = new System.Drawing.Point(84, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 169);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sách";
            // 
            // lv_htsach
            // 
            this.lv_htsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_htsach.HideSelection = false;
            this.lv_htsach.Location = new System.Drawing.Point(6, 30);
            this.lv_htsach.Name = "lv_htsach";
            this.lv_htsach.Size = new System.Drawing.Size(618, 133);
            this.lv_htsach.TabIndex = 1;
            this.lv_htsach.UseCompatibleStateImageBehavior = false;
            this.lv_htsach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " Mã Sách";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tác Giả";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thể loại";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Nhóm Sách";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_X.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.Location = new System.Drawing.Point(747, 12);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(41, 26);
            this.btn_X.TabIndex = 2;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            // 
            // frmtksach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtksach";
            this.Text = "frmtksach";
            this.Load += new System.EventHandler(this.frmtksach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.Button btn_tksach;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Button btn_thoattksach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_htsach;
        private System.Windows.Forms.ComboBox cmb_tktt;
        private System.Windows.Forms.ListView lv_httk;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_xoaTK;
        private System.Windows.Forms.Button btn_X;
    }
}