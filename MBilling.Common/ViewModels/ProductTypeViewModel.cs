
using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class ProductTypeViewModel : ViewModel<ProductType>
    {
        private readonly ProductType m_ProductType;
        public ProductTypeViewModel(ProductType _ProductType)
            : base(_ProductType)
        {
            m_ProductType = _ProductType;
        }

        public int ProductTypeId
        {
            get { return m_ProductType.ProductTypeId; }
            set { m_ProductType.ProductTypeId = value; }
        }

        public string ProductTypeName
        {
            get { return m_ProductType.ProductTypeName; }
            set { m_ProductType.ProductTypeName = value; }
        }
        public ProductType ProductTypeData { get { return m_ProductType; } }
    }
}
