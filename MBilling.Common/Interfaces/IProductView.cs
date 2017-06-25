using MBilling.Common.ViewModels;
using MBilling.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.Interfaces
{
    public interface IProductView : IView<ProductViewModel>
    {
        void ReadUserInput();
        void ShowProductType(IEnumerable<ProductTypeViewModel> lstProductTypeData);
        //void Close();

    }
}
