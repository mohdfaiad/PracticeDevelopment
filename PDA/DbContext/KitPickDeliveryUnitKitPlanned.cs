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
    
    public partial class KitPickDeliveryUnitKitPlanned
    {
        public string KitOrderNumber { get; set; }
        public string KitId { get; set; }
        public Nullable<decimal> QuantityToPick { get; set; }
        public Nullable<int> ObjectVersion { get; set; }
        public string SubKitOrderNumber { get; set; }
    
        public virtual KitPickDeliveryUnitPlanned KitPickDeliveryUnitPlanned { get; set; }
    }
}
