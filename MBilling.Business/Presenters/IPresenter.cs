using MBilling.Common.Interfaces;
using MBilling.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.UI.Presenters
{
    public interface IPresenter<Tview, Tmodel>
      where Tview : IView<Tmodel>
      where Tmodel : IModel
    {
        Tview _view { get; set; }
        event EventHandler OnViewInitialized;
        event EventHandler OnViewLoaded;
    }

}
