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
    
    public partial class SalesOrderTax
    {
        public int SalesOrderTaxId { get; set; }
        public int SalesOrderId { get; set; }
        public int TaxTypeId { get; set; }
        public Nullable<decimal> LineTotal { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
    }
}
