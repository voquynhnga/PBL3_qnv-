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
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.DonHangs = new HashSet<DonHang>();
            this.LichLams = new HashSet<LichLam>();
        }
    
        public int ID_NV { get; set; }
        public string NameNV { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public System.DateTime NS { get; set; }
        public string GT { get; set; }
        public string CCCD { get; set; }
        public string ChucVu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichLam> LichLams { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}