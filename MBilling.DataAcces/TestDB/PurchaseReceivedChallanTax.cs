//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBilling.DataAcces.TestDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseReceivedChallanTax
    {
        public int PurchaseReceivedChallanTaxID { get; set; }
        public int PurchaseReceivedChallanId { get; set; }
        public int TaxRateId { get; set; }
        public decimal LineTotal { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual PurchaseReceivedChallanHeader PurchaseReceivedChallanHeader { get; set; }
    }
}
