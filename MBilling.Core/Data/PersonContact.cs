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

    public partial class PersonContact
    {
        [Key]
        public int PersonContactId { get; set; }
        public int PersonId { get; set; }
        public string ContactName { get; set; }
        public string ContactPerson { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Nullable<int> CreateByUserId { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public Nullable<int> ModifiedByUserId { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
