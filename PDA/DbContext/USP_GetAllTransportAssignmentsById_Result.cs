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
    
    public partial class USP_GetAllTransportAssignmentsById_Result
    {
        public int TransportAssignmentId { get; set; }
        public int TransportAssignmentReferenceId { get; set; }
        public string SupplierId { get; set; }
        public string PackageNumber { get; set; }
        public string PickUpLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public int TransportAssignmentPriority { get; set; }
        public System.DateTime TransportAssignmentStatusTime { get; set; }
        public Nullable<int> TransportAssignmentCodeId { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    }
}
