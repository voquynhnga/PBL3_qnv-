//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public int ID_HoaDon { get; set; }
        public int ID_CTSP { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
    
        public virtual ChiTietSanPham ChiTietSanPham { get; set; }
        public virtual DonHang DonHang { get; set; }
    }
}
