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
    
    public partial class NewSequenceDeliveryUnit
    {
        public string DeliveryUnit { get; set; }
        public int Line { get; set; }
        public string AfterDeliveryUnit { get; set; }
        public decimal NewSequence { get; set; }
        public System.DateTime NewStartTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ProductionLine ProductionLine { get; set; }
    }
}