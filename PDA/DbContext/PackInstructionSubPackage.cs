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
    
    public partial class PackInstructionSubPackage
    {
        public int PackageInstructionSubPackageId { get; set; }
        public string SiteId { get; set; }
        public string SupplierId { get; set; }
        public string PartNumber { get; set; }
        public string SubPackageType { get; set; }
        public int NumberOfSubPackages { get; set; }
        public int SubPackageQuantity { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual PackInstruction PackInstruction { get; set; }
    }
}
