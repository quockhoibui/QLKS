//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiKhachSan
{
    using System;
    using System.Collections.Generic;
    
    public partial class BangThuePhong
    {
        public int ID { get; set; }
        public string IDPhong { get; set; }
        public string IDKhachHang { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<System.DateTime> CheckIn { get; set; }
        public Nullable<System.DateTime> CheckOut { get; set; }
        public Nullable<int> SoLuongNguoiLon { get; set; }
        public Nullable<int> SoLuongTreEm { get; set; }
        public int IDTrangThai { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual TrangThaiThuePhong TrangThaiThuePhong { get; set; }
        public virtual PhanHoi PhanHoi { get; set; }
        public virtual DichVu DichVu { get; set; }
    }
}