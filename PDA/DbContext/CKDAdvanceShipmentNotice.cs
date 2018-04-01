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
    
    public partial class CKDAdvanceShipmentNotice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CKDAdvanceShipmentNotice()
        {
            this.CKDASNMainPackages = new HashSet<CKDASNMainPackage>();
            this.CKDASNParts = new HashSet<CKDASNPart>();
        }
    
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public string ShipmentId { get; set; }
        public Nullable<System.DateTime> DispatchDate { get; set; }
        public string ShippingUnitId { get; set; }
        public string ShippingSiteId { get; set; }
        public string ReceivingSiteId { get; set; }
        public string ReceivingFactoryNumber { get; set; }
        public string MethodOfTransport { get; set; }
        public string WeightUnit { get; set; }
        public string Gate { get; set; }
        public Nullable<System.DateTime> ArrivedTime { get; set; }
        public string SAPInvoiceInfo { get; set; }
        public int ShipmentStatusId { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
        public string EntryDocument { get; set; }
        public Nullable<System.DateTime> EntryDocumentDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CKDASNMainPackage> CKDASNMainPackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CKDASNPart> CKDASNParts { get; set; }
    }
}