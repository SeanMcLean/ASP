//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebSite
{
    using System;
    using System.Collections.Generic;
    
    public partial class HISTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HISTORY()
        {
            this.MEMBERHISTORies = new HashSet<MEMBERHISTORY>();
        }
    
        public int History_ID { get; set; }
        public Nullable<System.DateTime> BorrowDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<decimal> OverDueFee { get; set; }
        public Nullable<int> ItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEMBERHISTORY> MEMBERHISTORies { get; set; }
        public virtual Item Item { get; set; }
    }
}
