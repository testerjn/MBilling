using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.Interfaces
{
    public interface IViewModel<M> : INotifyPropertyChanged where M : class
    {
        M Model { get; set; }
    }
}
