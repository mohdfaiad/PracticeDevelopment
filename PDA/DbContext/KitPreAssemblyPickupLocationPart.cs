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
    
    public partial class KitPreAssemblyPickupLocationPart
    {
        public string KitId { get; set; }
        public string LocationId { get; set; }
        public int StationPartId { get; set; }
        public string MultiPickLocationIndex { get; set; }
        public Nullable<int> MultiPickLocationSequence { get; set; }
        public string PickToPosition { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual KitPreAssemblyPickupLocation KitPreAssemblyPickupLocation { get; set; }
        public virtual StationPart StationPart { get; set; }
    }
}