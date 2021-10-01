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
    
    public partial class FormulirAktaKelahiran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormulirAktaKelahiran()
        {
            this.DetailAktaLahirs = new HashSet<DetailAktaLahir>();
        }
    
        public int IdFormAktaKelahiran { get; set; }
        public Nullable<int> IdFormFlow { get; set; }
        public Nullable<int> IdUserPelapor { get; set; }
        public string NamaBayi { get; set; }
        public Nullable<int> KelaminBayi { get; set; }
        public string TempatKelahiran { get; set; }
        public string HariKelahiran { get; set; }
        public Nullable<System.DateTime> TglLahir { get; set; }
        public Nullable<System.TimeSpan> WaktuKelahiran { get; set; }
        public Nullable<int> JenisKelahiran { get; set; }
        public Nullable<decimal> BeratBayi { get; set; }
        public Nullable<decimal> PanjangBayi { get; set; }
        public Nullable<int> AnakKe { get; set; }
        public string NamaIbu { get; set; }
        public string NikIbu { get; set; }
        public string PekerjaanIbu { get; set; }
        public Nullable<System.DateTime> TglLahirIbu { get; set; }
        public string AlamatIbu { get; set; }
        public string NamaAyah { get; set; }
        public Nullable<System.DateTime> TglLahirAyah { get; set; }
        public string PekerjaanAyah { get; set; }
        public string AlamatAyah { get; set; }
        public string NikAyah { get; set; }
        public string LinkDocAkta { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string Option1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailAktaLahir> DetailAktaLahirs { get; set; }
        public virtual User User { get; set; }
        public virtual MasterFlowFormulir MasterFlowFormulir { get; set; }
    }
}