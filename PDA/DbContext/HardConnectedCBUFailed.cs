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
    
    public partial class HardConnectedCBUFailed
    {
        public string DeliveryUnitId { get; set; }
        public string ComponentFamily { get; set; }
        public string SerialNumber { get; set; }
        public int Department { get; set; }
        public string AssemblyLine { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ProductionLine ProductionLine { get; set; }
    }
}
