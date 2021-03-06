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
    
    public partial class ComponentGroupException
    {
        public int ExceptionId { get; set; }
        public string CustomerId { get; set; }
        public string ReceiverId { get; set; }
        public string Flow { get; set; }
        public int ExceptionTypeId { get; set; }
        public string ExceptionTypeValue { get; set; }
        public bool RequirePacking { get; set; }
        public string PackingMasterGroupId { get; set; }
        public string ExtPackReferenceNumber { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
        public string EndFactoryId { get; set; }
    
        public virtual CustomerReceiver CustomerReceiver { get; set; }
        public virtual GroupingExceptionType GroupingExceptionType { get; set; }
        public virtual MasterGroup MasterGroup { get; set; }
        public virtual PackReferenceNumber PackReferenceNumber { get; set; }
    }
}
