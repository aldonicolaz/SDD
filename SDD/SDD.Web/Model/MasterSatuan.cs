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
    
    public partial class MasterSatuan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterSatuan()
        {
            this.DetailUserPertanians = new HashSet<DetailUserPertanian>();
            this.DetailUserPeternakanPerikanans = new HashSet<DetailUserPeternakanPerikanan>();
            this.MasterBudidayas = new HashSet<MasterBudidaya>();
            this.MasterHasilBudidayas = new HashSet<MasterHasilBudidaya>();
        }
    
        public int IdSatuan { get; set; }
        public string NamaSatuan { get; set; }
        public string DescSatuan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailUserPertanian> DetailUserPertanians { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailUserPeternakanPerikanan> DetailUserPeternakanPerikanans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterBudidaya> MasterBudidayas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterHasilBudidaya> MasterHasilBudidayas { get; set; }
    }
}