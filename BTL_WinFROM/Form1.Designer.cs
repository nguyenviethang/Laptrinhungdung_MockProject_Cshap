namespace BTL_WinFROM
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUẢNLÝToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.qLNhómSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHỐNGKÊToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tÌMKIẾMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dx = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_X = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(46, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUẢNLÝToolStripMenuItem,
            this.tHỐNGKÊToolStripMenuItem,
            this.tÌMKIẾMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qUẢNLÝToolStripMenuItem
            // 
            this.qUẢNLÝToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.độcGiảToolStripMenuItem,
            this.toolStripSeparator1,
            this.sáchToolStripMenuItem,
            this.toolStripSeparator2,
            this.hóaĐơnToolStripMenuItem});
            this.qUẢNLÝToolStripMenuItem.Name = "qUẢNLÝToolStripMenuItem";
            this.qUẢNLÝToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.qUẢNLÝToolStripMenuItem.Text = "QUẢN LÝ";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.độcGiảToolStripMenuItem.Text = "Độc Giả";
            this.độcGiảToolStripMenuItem.Click += new System.EventHandler(this.QLDG);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLSáchToolStripMenuItem,
            this.toolStripSeparator3,
            this.qLNhómSáchToolStripMenuItem});
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // qLSáchToolStripMenuItem
            // 
            this.qLSáchToolStripMenuItem.Name = "qLSáchToolStripMenuItem";
            this.qLSáchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.qLSáchToolStripMenuItem.Text = "QL Sách";
            this.qLSáchToolStripMenuItem.Click += new System.EventHandler(this.QLSach);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // qLNhómSáchToolStripMenuItem
            // 
            this.qLNhómSáchToolStripMenuItem.Name = "qLNhómSáchToolStripMenuItem";
            this.qLNhómSáchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.qLNhómSáchToolStripMenuItem.Text = "QL Nhóm Sách";
            this.qLNhómSáchToolStripMenuItem.Click += new System.EventHandler(this.qlnhomsach);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chonhd);
            // 
            // tHỐNGKÊToolStripMenuItem
            // 
            this.tHỐNGKÊToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêSáchToolStripMenuItem,
            this.thốngKêNgườiDùngToolStripMenuItem});
            this.tHỐNGKÊToolStripMenuItem.Name = "tHỐNGKÊToolStripMenuItem";
            this.tHỐNGKÊToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.tHỐNGKÊToolStripMenuItem.Text = "THỐNG KÊ";
            // 
            // thốngKêSáchToolStripMenuItem
            // 
            this.thốngKêSáchToolStripMenuItem.Name = "thốngKêSáchToolStripMenuItem";
            this.thốngKêSáchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.thốngKêSáchToolStripMenuItem.Text = "Thống Kê Sách ";
            this.thốngKêSáchToolStripMenuItem.Click += new System.EventHandler(this.tksachtv);
            // 
            // thốngKêNgườiDùngToolStripMenuItem
            // 
            this.thốngKêNgườiDùngToolStripMenuItem.Name = "thốngKêNgườiDùngToolStripMenuItem";
            this.thốngKêNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.thốngKêNgườiDùngToolStripMenuItem.Text = "Thời Hạn Trả Sách";
            this.thốngKêNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêNgườiDùngToolStripMenuItem_Click);
            // 
            // tÌMKIẾMToolStripMenuItem
            // 
            this.tÌMKIẾMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem1,
            this.ngườiDùngToolStripMenuItem});
            this.tÌMKIẾMToolStripMenuItem.Name = "tÌMKIẾMToolStripMenuItem";
            this.tÌMKIẾMToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tÌMKIẾMToolStripMenuItem.Text = "TÌM KIẾM";
            // 
            // sáchToolStripMenuItem1
            // 
            this.sáchToolStripMenuItem1.Name = "sáchToolStripMenuItem1";
            this.sáchToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.sáchToolStripMenuItem1.Text = "Sách";
            this.sáchToolStripMenuItem1.Click += new System.EventHandler(this.tksach);
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ngườiDùngToolStripMenuItem.Text = "Người Dùng";
            this.ngườiDùngToolStripMenuItem.Click += new System.EventHandler(this.tknguoidung);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần Mềm QL Thư Viện";
            // 
            // btn_dx
            // 
            this.btn_dx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_dx.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dx.Location = new System.Drawing.Point(618, 42);
            this.btn_dx.Name = "btn_dx";
            this.btn_dx.Size = new System.Drawing.Size(93, 29);
            this.btn_dx.TabIndex = 3;
            this.btn_dx.Text = "ĐĂNG XUẤT";
            this.btn_dx.UseVisualStyleBackColor = false;
            this.btn_dx.Click += new System.EventHandler(this.btn_dx_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BTL_WinFROM.Properties.Resources._39;
            this.panel1.Location = new System.Drawing.Point(96, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 280);
            this.panel1.TabIndex = 4;
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_X.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.Location = new System.Drawing.Point(747, 12);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(41, 26);
            this.btn_X.TabIndex = 5;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_dx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Quản lý Thư Viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem qLNhómSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHỐNGKÊToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tÌMKIẾMToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.Button btn_dx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_X;
    }
}

