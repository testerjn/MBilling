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
    
    public partial class TaxType
    {
        
        public TaxType()
        {
            this.PersonTaxes = new HashSet<PersonTax>();
        }
    
        public int TaxTypeId { get; set; }
        public string Name { get; set; }
        public short ValueLength { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        
        public virtual ICollection<PersonTax> PersonTaxes { get; set; }
    }
}
