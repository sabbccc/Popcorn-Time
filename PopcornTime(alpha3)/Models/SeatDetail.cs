//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PopcornTime_alpha3_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeatDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeatDetail()
        {
            this.PaymentTables = new HashSet<PaymentTable>();
        }
    
        public int SeatID { get; set; }
        public Nullable<int> HallNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentTable> PaymentTables { get; set; }
    }
}
