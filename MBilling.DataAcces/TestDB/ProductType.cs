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
    
    public partial class ProductType
    {
        public int ProductTypeId { get; set; }
        public string ProductType1 { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Product Product { get; set; }
    }
}