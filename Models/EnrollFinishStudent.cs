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
    
    public partial class EnrollFinishStudent
    {
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> FinishTypeId { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> TimeStam { get; set; }
        public Nullable<int> Staff { get; set; }
        public int FinishId { get; set; }
        public Nullable<int> FinishCouse { get; set; }
        public Nullable<System.DateTime> DayRequstFinish { get; set; }
        public Nullable<System.DateTime> DayFinished { get; set; }
        public Nullable<System.DateTime> DayToFinished { get; set; }
        public string Reader { get; set; }
        public string Physical { get; set; }
        public string Activity { get; set; }
        public string CouseBasic { get; set; }
        public string CouseAdd { get; set; }
        public string Reader2 { get; set; }
        public string Activity2 { get; set; }
        public string physical2 { get; set; }
        public Nullable<int> ExcelForm { get; set; }
    
        public virtual Students Students { get; set; }
        public virtual FinishType FinishType { get; set; }
    }
}
