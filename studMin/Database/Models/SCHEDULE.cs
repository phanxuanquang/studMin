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
    
    public partial class SCHEDULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHEDULE()
        {
            this.LESSONs = new HashSet<LESSON>();
        }
    
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> DATEAPPLY { get; set; }
        public Nullable<int> SCHOOLYEAR { get; set; }
        public Nullable<int> SEMESTER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LESSON> LESSONs { get; set; }
    }
}