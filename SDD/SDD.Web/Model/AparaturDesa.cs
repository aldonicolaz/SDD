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
    
    public partial class AparaturDesa
    {
        public int IdAparaturDesa { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<long> IdDesa { get; set; }
        public Nullable<int> IdJabatan { get; set; }
        public Nullable<int> StatusAparatur { get; set; }
        public Nullable<System.DateTime> PeriodeAwal { get; set; }
        public Nullable<System.DateTime> PeriodeAkhir { get; set; }
        public string DescAparaturDesa { get; set; }
    
        public virtual MasterJabatan MasterJabatan { get; set; }
        public virtual User User { get; set; }
        public virtual MasterDesa MasterDesa { get; set; }
    }
}
