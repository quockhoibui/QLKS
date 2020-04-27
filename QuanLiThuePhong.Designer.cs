namespace QuanLiKhachSan
{
    partial class QuanLiThuePhong
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiTenNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPhong = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbQuanLiPhong = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSoGiuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbGiaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.txbTenPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIDPhong = new System.Windows.Forms.TextBox();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.dtgvPhong = new System.Windows.Forms.DataGridView();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLiKhachSan.DataSet1();
            this.tbKhach = new System.Windows.Forms.TabControl();
            this.phongTableAdapter = new QuanLiKhachSan.DataSet1TableAdapters.PhongTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tbPhong.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbQuanLiPhong.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tbKhach.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thôngTinNhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.menuToolStripMenuItem.Text = "Quản lí phòng";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiTenNhanVien});
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            // 
            // tmiTenNhanVien
            // 
            this.tmiTenNhanVien.Name = "tmiTenNhanVien";
            this.tmiTenNhanVien.Size = new System.Drawing.Size(182, 26);
            this.tmiTenNhanVien.Text = "Tên nhân viên";
            // 
            // tbPhong
            // 
            this.tbPhong.Controls.Add(this.tabControl1);
            this.tbPhong.Location = new System.Drawing.Point(4, 25);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tbPhong.Size = new System.Drawing.Size(1523, 620);
            this.tbPhong.TabIndex = 0;
            this.tbPhong.Text = "Phòng";
            this.tbPhong.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbQuanLiPhong);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // tbQuanLiPhong
            // 
            this.tbQuanLiPhong.Controls.Add(this.panel1);
            this.tbQuanLiPhong.Controls.Add(this.dtgvPhong);
            this.tbQuanLiPhong.Location = new System.Drawing.Point(4, 25);
            this.tbQuanLiPhong.Name = "tbQuanLiPhong";
            this.tbQuanLiPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuanLiPhong.Size = new System.Drawing.Size(1219, 584);
            this.tbQuanLiPhong.TabIndex = 0;
            this.tbQuanLiPhong.Text = "Quản lí phòng";
            this.tbQuanLiPhong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.cbLoaiPhong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbSoGiuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbGiaPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.la);
            this.panel1.Controls.Add(this.txbTenPhong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbIDPhong);
            this.panel1.Controls.Add(this.btnXoaPhong);
            this.panel1.Controls.Add(this.btnSuaPhong);
            this.panel1.Controls.Add(this.btnThemPhong);
            this.panel1.Location = new System.Drawing.Point(610, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 377);
            this.panel1.TabIndex = 4;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(101, 148);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(163, 24);
            this.cbTrangThai.TabIndex = 16;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(101, 87);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(163, 24);
            this.cbLoaiPhong.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số giường";
            // 
            // txbSoGiuong
            // 
            this.txbSoGiuong.Location = new System.Drawing.Point(362, 160);
            this.txbSoGiuong.Name = "txbSoGiuong";
            this.txbSoGiuong.ReadOnly = true;
            this.txbSoGiuong.Size = new System.Drawing.Size(170, 22);
            this.txbSoGiuong.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá";
            // 
            // txbGiaPhong
            // 
            this.txbGiaPhong.Location = new System.Drawing.Point(362, 89);
            this.txbGiaPhong.Name = "txbGiaPhong";
            this.txbGiaPhong.ReadOnly = true;
            this.txbGiaPhong.Size = new System.Drawing.Size(170, 22);
            this.txbGiaPhong.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại phòng";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(279, 25);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(77, 17);
            this.la.TabIndex = 6;
            this.la.Text = "Tên phòng";
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.Location = new System.Drawing.Point(362, 22);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.Size = new System.Drawing.Size(170, 22);
            this.txbTenPhong.TabIndex = 5;
            this.txbTenPhong.TextChanged += new System.EventHandler(this.txbGiaPhong_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txbIDPhong
            // 
            this.txbIDPhong.Location = new System.Drawing.Point(101, 22);
            this.txbIDPhong.Name = "txbIDPhong";
            this.txbIDPhong.ReadOnly = true;
            this.txbIDPhong.Size = new System.Drawing.Size(163, 22);
            this.txbIDPhong.TabIndex = 3;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(469, 345);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(81, 23);
            this.btnXoaPhong.TabIndex = 2;
            this.btnXoaPhong.Text = "Xóa Phòng";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Location = new System.Drawing.Point(371, 345);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(81, 23);
            this.btnSuaPhong.TabIndex = 1;
            this.btnSuaPhong.Text = "Sửa Phòng";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(273, 345);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(81, 23);
            this.btnThemPhong.TabIndex = 0;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // dtgvPhong
            // 
            this.dtgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhong.Location = new System.Drawing.Point(8, 39);
            this.dtgvPhong.Name = "dtgvPhong";
            this.dtgvPhong.RowHeadersWidth = 51;
            this.dtgvPhong.RowTemplate.Height = 24;
            this.dtgvPhong.Size = new System.Drawing.Size(575, 378);
            this.dtgvPhong.TabIndex = 0;
            this.dtgvPhong.SelectionChanged += new System.EventHandler(this.dtgvPhong_SelectionChanged);
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbKhach
            // 
            this.tbKhach.Controls.Add(this.tbPhong);
            this.tbKhach.Location = new System.Drawing.Point(0, 44);
            this.tbKhach.Name = "tbKhach";
            this.tbKhach.SelectedIndex = 0;
            this.tbKhach.Size = new System.Drawing.Size(1531, 649);
            this.tbKhach.TabIndex = 1;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLiThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 733);
            this.Controls.Add(this.tbKhach);
            this.Controls.Add(this.menuStrip1);
            this.Name = "QuanLiThuePhong";
            this.Text = "Quản Lí Khách Sạn";
            this.Load += new System.EventHandler(this.QuanLiThuePhong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbPhong.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbQuanLiPhong.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tbKhach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiTenNhanVien;
        private System.Windows.Forms.TabPage tbPhong;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbQuanLiPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSoGiuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbGiaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox txbTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIDPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.DataGridView dtgvPhong;
        private System.Windows.Forms.TabControl tbKhach;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private DataSet1TableAdapters.PhongTableAdapter phongTableAdapter;
    }
}