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
    
    public partial class FormulirKK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormulirKK()
        {
            this.DetailFormulirKKs = new HashSet<DetailFormulirKK>();
            this.StatusFormFlows = new HashSet<StatusFormFlow>();
        }
    
        public int IdFormulirKK { get; set; }
        public Nullable<int> IdMasterFlow { get; set; }
        public Nullable<int> IdUser { get; set; }
        public string AlasanPemohon { get; set; }
        public Nullable<int> JumlahKK { get; set; }
        public string DokPendukungKK { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string LinkDocKK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailFormulirKK> DetailFormulirKKs { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatusFormFlow> StatusFormFlows { get; set; }
    }
}
