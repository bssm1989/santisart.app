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
    
    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            this.EnrollFamilyStudent = new HashSet<EnrollFamilyStudent>();
            this.EnrollFinishStudent = new HashSet<EnrollFinishStudent>();
            this.EnrollStudentCouse = new HashSet<EnrollStudentCouse>();
        }
    
        public int Student_id { get; set; }
        public string Student_title { get; set; }
        public string Student_name { get; set; }
        public string Student_lname { get; set; }
        public Nullable<System.DateTime> Student_birthday { get; set; }
        public string Student_idcard { get; set; }
        public Nullable<int> Student_psis_id { get; set; }
        public string Student_status { get; set; }
        public Nullable<System.DateTime> Student_timestamp { get; set; }
        public string Student_ArabName { get; set; }
        public string Student_OldSchool { get; set; }
        public string Studnet_Gender { get; set; }
        public Nullable<System.DateTime> Student_firsttime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollFamilyStudent> EnrollFamilyStudent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollFinishStudent> EnrollFinishStudent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollStudentCouse> EnrollStudentCouse { get; set; }
    }
}
