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
    
    public partial class RolePermission
    {
        public long RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public string PermissionKey { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
