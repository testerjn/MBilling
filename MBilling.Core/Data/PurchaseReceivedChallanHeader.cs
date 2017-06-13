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
    
    public partial class PurchaseReceivedChallanHeader
    {
        public int PurchaseReceivedChallanId { get; set; }
        public int PurchaseOrderID { get; set; }
        public int PersonId { get; set; }
        public string VendorChallanNo { get; set; }
        public Nullable<System.DateTime> VendorChallanDate { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> TaxAmt { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public Nullable<decimal> TotalDue { get; set; }
        public string Comment { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedByUserId { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.Guid> rowguid { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }
        public virtual PurchaseReceivedChallanTax PurchaseReceivedChallanTax { get; set; }
    }
}
