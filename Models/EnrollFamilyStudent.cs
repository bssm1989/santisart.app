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
    
    public partial class EnrollFamilyStudent
    {
        public int EnrollFamStudentId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> FamilyId { get; set; }
        public string TypeFamily { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string status { get; set; }
        public Nullable<int> staftId { get; set; }
    
        public virtual Family Family { get; set; }
        public virtual Students Students { get; set; }
    }
}
