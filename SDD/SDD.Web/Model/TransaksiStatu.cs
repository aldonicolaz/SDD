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
    
    public partial class TransaksiStatu
    {
        public int IdTransaksi { get; set; }
        public Nullable<int> IdMasterForm { get; set; }
        public Nullable<int> IdStatus { get; set; }
        public Nullable<int> IdUserPengajuan { get; set; }
        public string Keterangan { get; set; }
        public Nullable<int> IdUserAparat { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string Info { get; set; }
        public Nullable<int> IdTransaksiForm { get; set; }
    
        public virtual MasterFormulir MasterFormulir { get; set; }
    }
}