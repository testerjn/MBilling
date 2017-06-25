
using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class ProductViewModel : ViewModel<Product>
    {
        private readonly Product m_Product;
        public ProductViewModel(Product _Product)
            : base(_Product)
        {
            m_Product = _Product;
        }

        public int ProductId
        {
            get { return m_Product.ProductId; }
            set
            {
                if (value != m_Product.ProductId)
                {
                    m_Product.ProductId = value;
                    RaisePropertyChangedFor("ProductId");
                }
            }
        }
        public string Name
        {
            get { return m_Product.Name; }
            set { m_Product.Name = value; }
        }

        public string Description
        {
            get { return m_Product.Description; }
            set { m_Product.Description = value; }
        }

        public string Size
        {
            get { return m_Product.Size; }
            set { m_Product.Size = value; }
        }

        public string Unit
        {
            get { return m_Product.Unit; }
            set { m_Product.Unit = value; }
        }

        public int CreateByUserId
        {
            get { return m_Product.CreatedByUserId; }
            set { m_Product.CreatedByUserId = value; }
        }

        public int ModifiedByUserId
        {
            get { return m_Product.ModifiedByUserId; }
            set { m_Product.ModifiedByUserId = value; }
        }
        public Nullable<bool> IsActive
        {
            get { return m_Product.IsActive; }
            set { m_Product.IsActive = value; }
        }
        public Product ProductData { get { return m_Product; } }
    }
}
