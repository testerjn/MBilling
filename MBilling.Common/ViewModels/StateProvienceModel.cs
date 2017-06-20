using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class StateProvienceModel : ViewModel<StateProvince>
    {
        private readonly StateProvince m_StateProvinceData;

        public StateProvienceModel(StateProvince _StateProvince)
            : base(_StateProvince)
        {
            m_StateProvinceData = _StateProvince;
        }

        public int StateId
        {
            get { return m_StateProvinceData.StateId; }
            set
            {
                if (value != m_StateProvinceData.StateId)
                {
                    m_StateProvinceData.StateId = value;
                    RaisePropertyChangedFor("StateId");
                }
            }
        }
        public string FullName
        {
            get { return m_StateProvinceData.FullName; }
            set { m_StateProvinceData.FullName = value; }
        }

        public StateProvince StateProvinceData { get { return m_StateProvinceData; } }
    }
}
