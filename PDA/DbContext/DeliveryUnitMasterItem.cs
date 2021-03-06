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
    
    public partial class DeliveryUnitMasterItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryUnitMasterItem()
        {
            this.DeliveryUnits = new HashSet<DeliveryUnit>();
        }
    
        public string MasterItemId { get; set; }
        public string MainOrderId { get; set; }
        public string MasterItemState { get; set; }
        public Nullable<System.DateTime> ActualStartTime { get; set; }
        public Nullable<System.DateTime> ActualEndTime { get; set; }
        public Nullable<System.DateTime> PlannedStartTime { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string ModifiedBy { get; set; }
        public int ObjectVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryUnit> DeliveryUnits { get; set; }
        public virtual DeliveryUnitMainOrder DeliveryUnitMainOrder { get; set; }
    }
}
