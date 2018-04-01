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
    
    public partial class DeliveryNotePart
    {
        public int Id { get; set; }
        public string SupplierId { get; set; }
        public int AdvanceShipmentNoticeId { get; set; }
        public System.DateTime AdvanceShipmentNoticeTime { get; set; }
        public string PartNumber { get; set; }
        public string UnitCode { get; set; }
        public string DispatchedQuantity { get; set; }
        public string OrderId { get; set; }
        public Nullable<int> NumberOfSubPackages { get; set; }
        public string KanbanReference { get; set; }
        public string MHUNumber { get; set; }
        public Nullable<int> NetWeight { get; set; }
        public string OrderReference { get; set; }
        public string BatchId { get; set; }
        public string OriginCountry { get; set; }
        public string OriginatingProduct { get; set; }
        public string CurrencyCode { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    }
}