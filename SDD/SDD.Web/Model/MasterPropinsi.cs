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
    
    public partial class MasterPropinsi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterPropinsi()
        {
            this.MasterKabupatens = new HashSet<MasterKabupaten>();
        }
    
        public int IdPropinsi { get; set; }
        public string NamaPropinsi { get; set; }
        public string IbuKotaPropinsi { get; set; }
        public string LatitudePropinsi { get; set; }
        public string LongitudePropinsi { get; set; }
        public string DescPropinsi { get; set; }
        public string LogoPropinsi { get; set; }
        public string NoKodePropinsi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterKabupaten> MasterKabupatens { get; set; }
    }
}
