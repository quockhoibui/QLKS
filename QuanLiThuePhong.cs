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

namespace QuanLiKhachSan
{
    public partial class QuanLiThuePhong : Form
    {
        public QuanLiThuePhong()
        {
            InitializeComponent();
        }
        #region Method
        void LoadLoaiPhong(ComboBox cb)
        {
            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                cb.DataSource = db.LoaiPhong.ToList();
                cb.DisplayMember = "Ten";

            }
        }

        void LoadTinhTrang(ComboBox cb)
        {
            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                cb.DataSource = db.TinhTrang.ToList();
                cb.DisplayMember = "Ten";

            }
        }

        void BindingPhong(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgv.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txbIDPhong.DataBindings.Clear();
            txbIDPhong.DataBindings.Add(bdID);

            Binding bdTen = new Binding("Text", dtgv.DataSource, "Tên", true, DataSourceUpdateMode.OnPropertyChanged);
            txbTenPhong.DataBindings.Clear();
            txbTenPhong.DataBindings.Add(bdTen);


            Binding bdGia = new Binding("Text", dtgv.DataSource, "Giá", true, DataSourceUpdateMode.OnPropertyChanged);
            txbGiaPhong.DataBindings.Clear();
            txbGiaPhong.DataBindings.Add(bdGia);

            Binding bdSoGiuong = new Binding("Text", dtgv.DataSource, "Số_Giường", true, DataSourceUpdateMode.OnPropertyChanged);
            txbSoGiuong.DataBindings.Clear();
            txbSoGiuong.DataBindings.Add(bdSoGiuong);
        }


        //load thông tin phòng trong datagridview tương ứng

        void LoadPhong(DataGridView dtgv)
        {
            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                var source = from p in db.Phong
                             from l in db.LoaiPhong
                             from t in db.TinhTrang
                             where p.IDLoai.Equals(l.ID)
                             && p.IDTinhTrang.Equals(t.ID)
                             select new
                             {
                                 ID = p.ID,
                                 Tên = p.Ten,
                                 Loại = l.Ten,
                                 Status = t.Ten,
                                 Giá = l.Gia,
                                 Số_Giường = l.SoGiuong
                             };

                dtgv.DataSource = source.ToList();
            }

            BindingPhong(dtgvPhong);
        }

        void ThemPhong()
        {
            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                string id = (Int32.Parse(db.Phong.Select(m => m.ID).Max()) + 1).ToString();
                string ten = txbTenPhong.Text;

                if (db.Phong.Select(m=>m.Ten).Contains(ten))
                {
                    MessageBox.Show("Tên phòng đã tồn tại");
                    return;
                }
                int loai = (cbLoaiPhong.SelectedValue as LoaiPhong).ID;
                int trangthai = (cbTrangThai.SelectedValue as TinhTrang).ID;

                Phong p = new Phong()
                {
                    ID = id,
                    Ten = ten,
                    IDLoai = loai,
                    IDTinhTrang = trangthai
                };

                db.Phong.Add(p);
                db.SaveChanges();

                MessageBox.Show("Thêm phòng thành công");
                LoadPhong(dtgvPhong);
            }
        }

        void XoaPhong()
        {
            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                string id = txbIDPhong.Text;
             
                db.Phong.Remove(db.Phong.Find(id));
                db.SaveChanges();

                MessageBox.Show("Xóa phòng thành công");
                LoadPhong(dtgvPhong);
            }
        }

        void SuaPhong()
        {
            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                string id = txbIDPhong.Text;

                Phong phong = db.Phong.Find(id);

                int loai = (cbLoaiPhong.SelectedValue as LoaiPhong).ID;
                int trangthai = (cbTrangThai.SelectedValue as TinhTrang).ID;

                phong.IDLoai = loai;
                phong.IDTinhTrang = trangthai;

                
                db.SaveChanges();

                MessageBox.Show("Sửa phòng thành công");
                LoadPhong(dtgvPhong);
            }
        }
        #endregion

        #region Event

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhong();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuanLiThuePhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dataSet1.Phong);
            tmiTenNhanVien.Text = Cons.Cons.LoginNhanVien.Ten;
            LoadPhong(dtgvPhong);
            
            LoadLoaiPhong(cbLoaiPhong);
            LoadTinhTrang(cbTrangThai);
        }


        
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons.Cons.LoginNhanVien = null;
            this.Close();
        }

        

        

        private void txbGiaPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (cbLoaiPhong.DataSource == null || dtgvPhong.SelectedCells.Count == 0)
                return;
            string loai = dtgvPhong.SelectedCells[0].OwningRow.Cells["Loại"].Value.ToString();
            int index = 0;
            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                index = db.LoaiPhong.Select(p => p.Ten).ToList().IndexOf(loai);
            }


            cbLoaiPhong.SelectedIndex = index;

            if (cbTrangThai.DataSource == null || dtgvPhong.SelectedCells.Count == 0)
                return;
            string loaiTrangThai = dtgvPhong.SelectedCells[0].OwningRow.Cells["Loại"].Value.ToString();
            int index2 = 0;
            using (QuanLiKhachSanEntities db = new QuanLiKhachSanEntities())
            {
                index2 = db.LoaiPhong.Select(p => p.Ten).ToList().IndexOf(loaiTrangThai);
            }


            cbTrangThai.SelectedIndex = index2;

        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            XoaPhong();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            SuaPhong();
        }

        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
    }
}


