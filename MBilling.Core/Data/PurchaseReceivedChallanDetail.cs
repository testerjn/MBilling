//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBilling.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PurchaseReceivedChallanDetail
    {
        public int PurchaseReceivedChallanId { get; set; }
        [Key]
        public int PurchaseReceivedChallanDetailID { get; set; }
        public int ProductID { get; set; }
        public short OrderQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public int CreatedByUserId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int ModifiedByUserId { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.Guid rowguid { get; set; }
    }
}
