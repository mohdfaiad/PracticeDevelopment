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
    
    public partial class LoadListSubItem
    {
        public int Id { get; set; }
        public int LoadListMainItemId { get; set; }
        public string CPOId { get; set; }
        public int ComponentPosition { get; set; }
        public string SupplierId { get; set; }
        public string SubPackageId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual CustomerOrderSequence CustomerOrderSequence { get; set; }
        public virtual LoadListMainItem LoadListMainItem { get; set; }
    }
}