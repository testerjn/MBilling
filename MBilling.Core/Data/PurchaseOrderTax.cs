//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBilling.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrderTax
    {
        public int PurchaseOrderID { get; set; }
        public int PurchaseTaxId { get; set; }
        public int TaxRateId { get; set; }
        public decimal LineTotal { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }
    }
}
