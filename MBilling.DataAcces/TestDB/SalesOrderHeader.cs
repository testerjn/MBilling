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
    
    public partial class SalesOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrderHeader()
        {
            this.SalesOrderTaxes = new HashSet<SalesOrderTax>();
        }
    
        public int SalesOrderId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string SalesOrderNumber { get; set; }
        public string QuotationRef { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<int> BillToAddressID { get; set; }
        public Nullable<int> ShipToAddressID { get; set; }
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderTax> SalesOrderTaxes { get; set; }
    }
}
