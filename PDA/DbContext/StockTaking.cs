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
    
    public partial class StockTaking
    {
        public int Id { get; set; }
        public string ImportedBy { get; set; }
        public Nullable<System.DateTime> ImportedTime { get; set; }
        public string PublishedBy { get; set; }
        public Nullable<System.DateTime> PublishedTime { get; set; }
        public string ExportedBy { get; set; }
        public Nullable<System.DateTime> ExportedTime { get; set; }
        public int ObjectVersion { get; set; }
    }
}
