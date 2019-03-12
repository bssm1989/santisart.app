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
    
    public partial class EnrollCouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnrollCouse()
        {
            this.EnrollStudentCouse = new HashSet<EnrollStudentCouse>();
            this.EnrollEmpCouse = new HashSet<EnrollEmpCouse>();
        }
    
        public string CouseTxtId { get; set; }
        public Nullable<int> CouseId { get; set; }
        public Nullable<int> DepartId { get; set; }
        public Nullable<int> CouseTime { get; set; }
        public Nullable<float> CouseWeight__ { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> semester__ { get; set; }
        public int EnrollCouseID { get; set; }
        public string CouseExcel { get; set; }
        public string ExcelAdress { get; set; }
        public Nullable<int> IndexSort { get; set; }
        public Nullable<int> EmpId { get; set; }
    
        public virtual ClassInSchool ClassInSchool { get; set; }
        public virtual Course Course { get; set; }
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollStudentCouse> EnrollStudentCouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollEmpCouse> EnrollEmpCouse { get; set; }
        public virtual EnrollEmpCouse EnrollEmpCouse1 { get; set; }
    }
}
