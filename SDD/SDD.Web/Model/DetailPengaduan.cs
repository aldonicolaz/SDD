//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailPengaduan
    {
        public int IdDetailPengaduan { get; set; }
        public Nullable<int> IdPengaduan { get; set; }
        public Nullable<int> IdUserPenanggap { get; set; }
        public string Tanggapan { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
    
        public virtual Pengaduan Pengaduan { get; set; }
        public virtual User User { get; set; }
    }
}
