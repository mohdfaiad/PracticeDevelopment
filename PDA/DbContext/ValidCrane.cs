//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDA.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class ValidCrane
    {
        public int Crane { get; set; }
        public string DepartmentId { get; set; }
        public int LocationGroupId { get; set; }
        public int MaxQueue { get; set; }
        public int NoOfAssignmentForStandby { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual LocationGroup LocationGroup { get; set; }
    }
}
