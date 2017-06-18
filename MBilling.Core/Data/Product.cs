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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Product
    {
        
        public Product()
        {
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }

        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }

        [Key,ForeignKey("ProductType")]
        [Column(Order = 2)]
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Unit { get; set; }
        public Nullable<int> CreateByUserId { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public Nullable<int> ModifiedByUserId { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual ProductType ProductType { get; set; }
        
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
