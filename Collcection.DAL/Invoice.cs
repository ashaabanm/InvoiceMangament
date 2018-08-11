//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Collcection.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int id { get; set; }
        public int invoice_no { get; set; }
        public int Amount { get; set; }
        public Nullable<System.DateTime> Issue_Date { get; set; }
        public Nullable<System.DateTime> Collect_Date { get; set; }
        public Nullable<System.DateTime> Act_C_Date { get; set; }
        public Nullable<bool> Collected { get; set; }
        public Nullable<int> Customer_Id { get; set; }
        public Nullable<bool> Suspended { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
