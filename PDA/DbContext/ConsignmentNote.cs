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
    
    public partial class ConsignmentNote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConsignmentNote()
        {
            this.LoadListDispatchNotes = new HashSet<LoadListDispatchNote>();
        }
    
        public string ConsignmentNoteID { get; set; }
        public string KDBatchNo { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> ClosedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ConsignmentNoteStatu ConsignmentNoteStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoadListDispatchNote> LoadListDispatchNotes { get; set; }
    }
}
