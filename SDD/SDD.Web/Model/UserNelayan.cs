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
    
    public partial class UserNelayan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserNelayan()
        {
            this.DetailKapalNelayans = new HashSet<DetailKapalNelayan>();
        }
    
        public int IdUserNelayan { get; set; }
        public Nullable<int> IdUser { get; set; }
        public string Desc { get; set; }
        public Nullable<int> IdPekerjaan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailKapalNelayan> DetailKapalNelayans { get; set; }
        public virtual User User { get; set; }
    }
}