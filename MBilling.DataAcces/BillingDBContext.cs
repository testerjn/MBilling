using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces
{
    public partial class BillingDBContext : DbContext
    {
        public BillingDBContext()
            : base("name=MErpBillingEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLogs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonContact> PersonContacts { get; set; }
        public virtual DbSet<PersonTax> PersonTaxes { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual DbSet<PurchaseOrderTax> PurchaseOrderTaxes { get; set; }
        public virtual DbSet<PurchaseReceivedChallanDetail> PurchaseReceivedChallanDetails { get; set; }
        public virtual DbSet<PurchaseReceivedChallanHeader> PurchaseReceivedChallanHeaders { get; set; }
        public virtual DbSet<PurchaseReceivedChallanTax> PurchaseReceivedChallanTaxes { get; set; }
        public virtual DbSet<QuotationDetail> QuotationDetails { get; set; }
        public virtual DbSet<QuotationHeader> QuotationHeaders { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual DbSet<SalesOrderTax> SalesOrderTaxes { get; set; }
        public virtual DbSet<TaxRate> TaxRates { get; set; }
        public virtual DbSet<TaxType> TaxTypes { get; set; }
        public virtual DbSet<WorkOrderDetail> WorkOrderDetails { get; set; }
        public virtual DbSet<WorkOrderHeader> WorkOrderHeaders { get; set; }
        public virtual DbSet<WorkOrderReceivedChallanDetail> WorkOrderReceivedChallanDetails { get; set; }
        public virtual DbSet<WorkOrderReceivedChallanHeader> WorkOrderReceivedChallanHeaders { get; set; }
        public virtual DbSet<WorkOrderReceivedChallanTax> WorkOrderReceivedChallanTaxes { get; set; }
        public virtual DbSet<WorkOrderTax> WorkOrderTaxes { get; set; }
    }
}
