using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // khi nhấn vào button Đăng nhập sẽ thực hiện show form tương ứng và ẩn form đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // xử lí đăng nhập để lấy ra form tương ứng
            Form f = nextForm(txbUserID.Text, txbPassword.Text);
            if (f == null)
                return;

            // xử lí khi đóng form khác thì sẽ show lại form đăng nhập
            f.FormClosed += F_FormClosed;
            // set vị trí cho các form mở ra luôn là center screen
            f.StartPosition = FormStartPosition.CenterScreen;
            //show form lên
            f.Show();
            // ẩn form này đi
            this.Hide();
            //clear textbox
            ClearTextbox();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        void ClearTextbox()
        {
            txbUserID.Clear();
            txbPassword.Clear();
        }

        Form nextForm(string id, string pass)
        {
            Form f = new Form();

            int roll = (int)Cons.Roll.TiepTan;

            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                var t = db.Users.Where(p => p.IDNhanVien.Equals(id) && p.Pass.Equals(pass));
                Users u = t.Count() == 1 ? t.Single() : null;
                if (u != null)
                {
                    NhanVien nv = db.NhanVien.Where(p => u.IDNhanVien.Equals(p.ID)).Single();
                    roll = (int)nv.ChucDanh.Roll;

                    Cons.Cons.LoginNhanVien = nv;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    return null;
                }
            }

            switch(roll)
            {
                case (int)Cons.Roll.TiepTan:
                    f = new QuanLiThuePhong();
                    break;       
            }

            return f;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
