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
    
    public partial class PersonTax
    {
        public int PersonTaxId { get; set; }
        public int PersonId { get; set; }
        public int TaxTypeId { get; set; }
        public string TaxValue { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual TaxType TaxType { get; set; }
    }
}
