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
    
    public partial class DetailFormulirKK
    {
        public int IdDetailKK { get; set; }
        public Nullable<int> IdFormulirKK { get; set; }
        public Nullable<int> IdMasterHub { get; set; }
        public string NIK { get; set; }
        public string NamaLengkap { get; set; }
    
        public virtual FormulirKK FormulirKK { get; set; }
        public virtual MasterHubungan MasterHubungan { get; set; }
    }
}
