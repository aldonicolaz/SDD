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
    
    public partial class MasterKecamatan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterKecamatan()
        {
            this.MasterDesas = new HashSet<MasterDesa>();
        }
    
        public int idKecamatan { get; set; }
        public int IdKabupaten { get; set; }
        public string NamaKecamatan { get; set; }
        public string LangtitudeKecamatan { get; set; }
        public string LongtitudeKecamatan { get; set; }
        public string KodePos { get; set; }
        public string DecKecamatan { get; set; }
        public string LogoKecamatan { get; set; }
        public string NoKodeKecamatan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterDesa> MasterDesas { get; set; }
        public virtual MasterKabupaten MasterKabupaten { get; set; }
    }
}
