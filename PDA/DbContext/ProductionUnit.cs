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
    
    public partial class ProductionUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductionUnit()
        {
            this.ProductionUnitDocumentations = new HashSet<ProductionUnitDocumentation>();
        }
    
        public string SerialNumber { get; set; }
        public Nullable<bool> TotalAvailable { get; set; }
        public string Activity { get; set; }
        public string Status { get; set; }
        public Nullable<bool> VSPCheck { get; set; }
        public Nullable<bool> LoadBlocked { get; set; }
        public string ActivityDescription { get; set; }
        public string StatusDescription { get; set; }
        public bool ReturnedComponent { get; set; }
        public string ProductUnitType { get; set; }
        public Nullable<System.DateTime> LastProdSystemUpdateTime { get; set; }
        public int ObjectVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionUnitDocumentation> ProductionUnitDocumentations { get; set; }
    }
}