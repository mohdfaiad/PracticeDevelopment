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
    
    public partial class ActivityLocation
    {
        public int Line { get; set; }
        public string Activity { get; set; }
        public string Location { get; set; }
        public bool RejectLocation { get; set; }
        public string PickUpId { get; set; }
        public string Identifier { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual Location Location1 { get; set; }
        public virtual ProductionLine ProductionLine { get; set; }
    }
}