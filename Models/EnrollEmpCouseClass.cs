//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace santisart_app.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnrollEmpCouseClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnrollEmpCouseClass()
        {
            this.EnrollStudentCouses = new HashSet<EnrollStudentCouse>();
        }
    
        public int EnrollEmpCouseClassId { get; set; }
        public Nullable<int> EnEmpCouseId { get; set; }
        public Nullable<int> EnClassId { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual EnrollClass EnrollClass { get; set; }
        public virtual EnrollEmpCouse EnrollEmpCouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollStudentCouse> EnrollStudentCouses { get; set; }
    }
}
