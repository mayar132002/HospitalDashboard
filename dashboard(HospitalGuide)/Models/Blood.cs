//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dashboard_HospitalGuide_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blood
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blood()
        {
            this.BloodNeeds = new HashSet<BloodNeed>();
        }
    
        public int Blood_ID { get; set; }
        public string Blood1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BloodNeed> BloodNeeds { get; set; }
    }
}
