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
    
    public partial class USP_GetPackageDetails_Result
    {
        public string MainPackageStatus { get; set; }
        public string CurrentLocation { get; set; }
        public int ASNId { get; set; }
        public string packageType { get; set; }
        public decimal packageMaximumWeight { get; set; }
        public int MainPackageQTY { get; set; }
        public int lotPackageQty { get; set; }
        public Nullable<bool> lotPackageExists { get; set; }
        public string MHU { get; set; }
        public string OriginalSupplierId { get; set; }
        public string OriginalSubPackageId { get; set; }
        public string OriginalMainPackageId { get; set; }
        public int PrtSupPalletFrames { get; set; }
        public string PrtSuppackageType { get; set; }
        public int PrtSupPackageWeight { get; set; }
        public decimal PrtSupPackageMaximumWeight { get; set; }
    }
}
