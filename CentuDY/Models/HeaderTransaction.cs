//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentuDY.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HeaderTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HeaderTransaction()
        {
            this.DetailTransactions = new HashSet<DetailTransaction>();
        }
    
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public string TransactionDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailTransaction> DetailTransactions { get; set; }
        public virtual User User { get; set; }
    }
}
