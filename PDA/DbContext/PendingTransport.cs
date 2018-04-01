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
    
    public partial class PendingTransport
    {
        public string SupplierId { get; set; }
        public string MainPackageId { get; set; }
        public Nullable<int> FromDepartment { get; set; }
        public string FromActivity { get; set; }
        public Nullable<int> ToDepartment { get; set; }
        public string ToActivity { get; set; }
        public Nullable<bool> Transport { get; set; }
        public Nullable<bool> TransportWait { get; set; }
        public Nullable<System.DateTime> TriggerTime { get; set; }
        public bool RejectLocation { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ProductionLine ProductionLine { get; set; }
        public virtual ProductionLine ProductionLine1 { get; set; }
    }
}