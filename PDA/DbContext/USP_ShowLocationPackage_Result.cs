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
    
    public partial class USP_ShowLocationPackage_Result
    {
        public string LocationId { get; set; }
        public string LocationType { get; set; }
        public string LocationStatus { get; set; }
        public int PalletFrames { get; set; }
        public int MaximumTransportTo { get; set; }
        public int ZoneNumber { get; set; }
        public string VC_MasterGroup { get; set; }
        public string VC_MasterType { get; set; }
        public string VC_SupplierId { get; set; }
        public string VC_MainPackageId { get; set; }
        public Nullable<int> VC_AssignmentNumber { get; set; }
        public string VC_PickUpLocation { get; set; }
        public string VC_DeliveryLocation { get; set; }
        public string OwningDepartment { get; set; }
        public int ObjectVersion { get; set; }
        public string VC_PartNumber { get; set; }
        public string VC_OriginalSupplierId { get; set; }
        public string VC_PackageId { get; set; }
        public Nullable<int> VC_PackageQuantity { get; set; }
        public string VC_PalletType { get; set; }
        public string VC_FullPlaceFree { get; set; }
        public string VC_InnerPlaceFree { get; set; }
        public string VC_OuterPlaceFree { get; set; }
    }
}
