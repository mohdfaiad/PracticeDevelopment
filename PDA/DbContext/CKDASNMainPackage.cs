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
    
    public partial class CKDASNMainPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CKDASNMainPackage()
        {
            this.CKDASNSubPackages = new HashSet<CKDASNSubPackage>();
        }
    
        public int ASNId { get; set; }
        public string MainPackageId { get; set; }
        public string ContainerId { get; set; }
        public Nullable<int> ContainerGrossWeight { get; set; }
        public Nullable<int> ContainerNetWeight { get; set; }
        public Nullable<int> ContainerVolume { get; set; }
        public Nullable<int> PackageGrossWeight { get; set; }
        public Nullable<int> PackageNetWeight { get; set; }
        public Nullable<int> PackageVolume { get; set; }
        public string PackageType { get; set; }
        public string PalletType { get; set; }
        public string SupplierReference { get; set; }
        public string Aggr1Flag { get; set; }
        public string Aggr2Flag { get; set; }
        public string CarrierName { get; set; }
        public string TrailerId { get; set; }
        public string UserId { get; set; }
        public Nullable<int> FlightExpressId { get; set; }
        public Nullable<System.DateTime> ReceivingTime { get; set; }
        public Nullable<bool> AutoASN { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual CKDAdvanceShipmentNotice CKDAdvanceShipmentNotice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CKDASNSubPackage> CKDASNSubPackages { get; set; }
    }
}
