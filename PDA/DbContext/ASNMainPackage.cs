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
    
    public partial class ASNMainPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ASNMainPackage()
        {
            this.ASNSubPackages = new HashSet<ASNSubPackage>();
        }
    
        public int ASNId { get; set; }
        public string MainPackageId { get; set; }
        public string PackageType { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public Nullable<System.DateTime> ReceivingTime { get; set; }
        public bool AutoASN { get; set; }
        public bool PreBlocked { get; set; }
        public string UserId { get; set; }
        public string OriginalPackageId { get; set; }
        public string FinalUnloadingPoint { get; set; }
        public string PackReferenceNumber { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual AdvanceShipmentNotice AdvanceShipmentNotice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASNSubPackage> ASNSubPackages { get; set; }
    }
}
