using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.Interfaces
{
    public interface IView<M> where M : class
    {
        string Message { get; set; }
        M MyModel { get; set; }
        string Title { get; set; }
        void GetAll(IEnumerable<M> modelList);
        void ShowModel(M myModel);
        void ShowError();
        void SearchModel(IEnumerable<M> modelList);
        void ClearControls();
        void Close();
    }
}
