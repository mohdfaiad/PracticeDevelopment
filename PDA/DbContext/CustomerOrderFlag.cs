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
    
    public partial class CustomerOrderFlag
    {
        public string CPOId { get; set; }
        public string Flag { get; set; }
        public string FlagValue { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual CustomerOrderSequence CustomerOrderSequence { get; set; }
    }
}