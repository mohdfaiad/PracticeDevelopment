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
    
    public partial class KitPreparationError
    {
        public int ErrorId { get; set; }
        public string KitId { get; set; }
        public string KitType { get; set; }
        public string KitStatus { get; set; }
        public string ErrorType { get; set; }
        public string MasterGroup { get; set; }
        public string PartNumber { get; set; }
        public string Location { get; set; }
        public string EquipmentName { get; set; }
        public string ErrorMessage { get; set; }
        public string UserId { get; set; }
        public System.DateTime LastCheckTime { get; set; }
        public int ObjectVersion { get; set; }
    }
}
