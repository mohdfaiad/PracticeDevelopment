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
    
    public partial class PartOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PartOrder()
        {
            this.DeliveryNotes = new HashSet<DeliveryNote>();
            this.PartOrderPartialDeliveries = new HashSet<PartOrderPartialDelivery>();
            this.SubPackageBookings = new HashSet<SubPackageBooking>();
            this.TransportUnitLoads = new HashSet<TransportUnitLoad>();
        }
    
        public string PartOrderNumber { get; set; }
        public string PartNumber { get; set; }
        public int PartOrderTypeId { get; set; }
        public System.DateTime PartOrderTime { get; set; }
        public System.DateTime PartOrderNeedDate { get; set; }
        public int PartOrderQuantity { get; set; }
        public int EconomicOrderNumber { get; set; }
        public string Customer { get; set; }
        public string Receiver { get; set; }
        public string OrderLocation { get; set; }
        public int PartOrderCategory { get; set; }
        public int ReplenishmentQuantity { get; set; }
        public string Storage { get; set; }
        public string ReceivingAddress { get; set; }
        public string ReceivingDepartment { get; set; }
        public Nullable<System.DateTime> PartShortageTime { get; set; }
        public string MaterialHandlingUnit { get; set; }
        public string CostCenter { get; set; }
        public int SubPackageStatusCode { get; set; }
        public string BusinessAddress { get; set; }
        public string Note { get; set; }
        public int OrderLines { get; set; }
        public string ParentPartNumber { get; set; }
        public string CustomerReferenceNumber { get; set; }
        public string DeliveryUnit { get; set; }
        public int SequenceNumber { get; set; }
        public string DeliveryGroup { get; set; }
        public string EmballageType { get; set; }
        public string EmballagePartNumber { get; set; }
        public string PackagingCode { get; set; }
        public string SampleCode { get; set; }
        public string OperationId { get; set; }
        public string ShipmentNumber { get; set; }
        public int DeliveredQuantity { get; set; }
        public bool PreOrder { get; set; }
        public string DropLocation { get; set; }
        public string SerialNumber { get; set; }
        public string KitId { get; set; }
        public string KitOrderNumber { get; set; }
        public string CPOId { get; set; }
        public Nullable<int> LoosePartItemId { get; set; }
        public string ExternalOrderSystem { get; set; }
        public string ExternalPartOrderNumber { get; set; }
        public bool SentToExternalSystem { get; set; }
        public int ExternalPartorderQuantity { get; set; }
        public string KDBatchNo { get; set; }
        public string UsePoint { get; set; }
        public string ChassisNumber { get; set; }
        public string ChassisType { get; set; }
        public string ExecutionOrderId { get; set; }
        public string MasterGroupId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
        public int NoOfSentTAlert { get; set; }
        public Nullable<System.DateTime> SentToExternalSystemTime { get; set; }
        public string ParentPartOrderNumber { get; set; }
    
        public virtual CustomerOrderSequence CustomerOrderSequence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryNote> DeliveryNotes { get; set; }
        public virtual Location Location { get; set; }
        public virtual LoosePartItem LoosePartItem { get; set; }
        public virtual MasterGroup MasterGroup { get; set; }
        public virtual Part Part { get; set; }
        public virtual PartOrderType PartOrderType { get; set; }
        public virtual PartOrderBooking PartOrderBooking { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartOrderPartialDelivery> PartOrderPartialDeliveries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubPackageBooking> SubPackageBookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportUnitLoad> TransportUnitLoads { get; set; }
    }
}
