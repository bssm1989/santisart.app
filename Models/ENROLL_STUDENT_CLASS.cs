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
    
    public partial class Enroll_student_class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enroll_student_class()
        {
            this.EnrollStudentCouses = new HashSet<EnrollStudentCouse>();
        }
    
        public Nullable<int> Student_id { get; set; }
        public Nullable<int> Class_id { get; set; }
        public int Enrol_stu_class_id { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
    
        public virtual EnrollClass EnrollClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollStudentCouse> EnrollStudentCouses { get; set; }
        public virtual Student Student { get; set; }
    }
}
