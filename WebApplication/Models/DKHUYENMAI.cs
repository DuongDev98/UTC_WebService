//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DKHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DKHUYENMAI()
        {
            this.DKHUYENMAICHITIETs = new HashSet<DKHUYENMAICHITIET>();
            this.TDONHANGs = new HashSet<TDONHANG>();
            this.TDONHANGCHITIETs = new HashSet<TDONHANGCHITIET>();
        }
    
        public string ID { get; set; }
        public string NAME { get; set; }
        public Nullable<System.DateTime> TUGIO { get; set; }
        public Nullable<System.DateTime> DENGIO { get; set; }
        public Nullable<System.DateTime> TUNGAY { get; set; }
        public Nullable<System.DateTime> DENNGAY { get; set; }
        public Nullable<int> LOAI { get; set; }
        public string DNHOMMATHANGID { get; set; }
        public Nullable<decimal> PHANTRAMGIAMGIA { get; set; }
        public Nullable<decimal> TONGBILL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DKHUYENMAICHITIET> DKHUYENMAICHITIETs { get; set; }
        public virtual DNHOMMATHANG DNHOMMATHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TDONHANG> TDONHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TDONHANGCHITIET> TDONHANGCHITIETs { get; set; }
    }
}
