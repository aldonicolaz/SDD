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
    
    public partial class ViewPertanian
    {
        public Nullable<long> IdNumber { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string NoKTP { get; set; }
        public string NoKK { get; set; }
        public string PhoneNumber { get; set; }
        public string WaNumber { get; set; }
        public Nullable<long> IdDesa { get; set; }
        public string NamaDesa { get; set; }
        public int idKecamatan { get; set; }
        public string NamaKecamatan { get; set; }
        public int IdKabupaten { get; set; }
        public string NamaKabupaten { get; set; }
        public int IdPropinsi { get; set; }
        public string NamaPropinsi { get; set; }
        public Nullable<decimal> TotalPenghasilanPertanian { get; set; }
        public string NamaPekerjaan { get; set; }
        public int IdPekerjaan { get; set; }
        public string NamaBudidaya { get; set; }
    }
}
