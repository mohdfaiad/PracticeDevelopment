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
    
    public partial class USP_CheckForGPackage_Result
    {
        public int ASNId { get; set; }
        public string MainPackageId { get; set; }
        public string PackageType { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public Nullable<System.DateTime> ReceivingTime { get; set; }
        public bool AutoASN { get; set; }
        public string PackReferenceNumber { get; set; }
        public bool PreBlocked { get; set; }
        public string UserId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
        public string FinalUnloadingPoint { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> ShipmentNoticeId { get; set; }
        public Nullable<int> ArrivedTime { get; set; }
        public Nullable<int> TotalQuantity { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}