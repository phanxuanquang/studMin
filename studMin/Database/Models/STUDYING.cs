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
    
    public partial class STUDYING
    {
        public System.Guid IDCLASS { get; set; }
        public System.Guid IDSTUDENT { get; set; }
        public Nullable<int> SCHOOLYEAR { get; set; }
        public int SEMESTER { get; set; }
    
        public virtual CLASS CLASS { get; set; }
        public virtual STUDENT STUDENT { get; set; }
    }
}