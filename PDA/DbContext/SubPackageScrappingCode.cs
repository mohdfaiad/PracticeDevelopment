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
    
    public partial class SubPackageScrappingCode
    {
        public int Id { get; set; }
        public string SiteId { get; set; }
        public string ReasonCode { get; set; }
        public string Account { get; set; }
        public bool ExternalScrappingFlag { get; set; }
        public bool PhaseOutFlag { get; set; }
        public string Description { get; set; }
        public bool ShowInFeedBackLocation { get; set; }
        public int ObjectVersion { get; set; }
    }
}
