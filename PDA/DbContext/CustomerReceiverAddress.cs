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
    
    public partial class CustomerReceiverAddress
    {
        public string CustomerId { get; set; }
        public string ReceiverId { get; set; }
        public string EndFactory { get; set; }
        public Nullable<int> ShipToAddressId { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual CustomerReceiver CustomerReceiver { get; set; }
        public virtual DispatchAddress DispatchAddress { get; set; }
    }
}