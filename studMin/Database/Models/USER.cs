//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace studMin.Database.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        public System.Guid ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAYNAME { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.Guid> IDINFO { get; set; }
    
        public virtual MEMBER MEMBER { get; set; }
    }
}