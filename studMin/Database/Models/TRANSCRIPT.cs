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
    
    public partial class TRANSCRIPT
    {
        public System.Guid ID { get; set; }
        public string SCHOOLYEAR { get; set; }
        public Nullable<int> SEMESTER { get; set; }
        public Nullable<System.Guid> IDSTUDENT { get; set; }
        public string CONDUCT { get; set; }
        public string RANK { get; set; }
    
        public virtual STUDENT STUDENT { get; set; }
    }
}
