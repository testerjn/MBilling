using MBilling.Core;
using MBilling.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class TaxRateViewModel : ViewModel<TaxRate>
    {
        private readonly TaxRate m_TaxRateData;

        public TaxRateViewModel(TaxRate _TaxRate)
            : base(_TaxRate)
        {
            m_TaxRateData = _TaxRate;
        }

        public int TaxRateId
        {
            get { return m_TaxRateData.TaxRateId; }
            set { m_TaxRateData.TaxRateId = value; }
        }

        public int StateProvinceId
        {
            get { return m_TaxRateData.StateProvinceId; }
            set
            {
                if (value != m_TaxRateData.StateProvinceId)
                {
                    m_TaxRateData.StateProvinceId = value;
                    RaisePropertyChangedFor("StateProvinceId");
                }
            }
        }
        public byte TaxType
        {
            get { return m_TaxRateData.TaxType; }
            set { m_TaxRateData.TaxType = value; }
        }
        public decimal TaxRate1
        {
            get { return m_TaxRateData.TaxRate1; }
            set { m_TaxRateData.TaxRate1 = value; }
        }
        public string TaxName
        {
            get { return m_TaxRateData.TaxName; }
            set { m_TaxRateData.TaxName = value; }
        }
        public System.DateTime ApplyDate
        {
            get { return m_TaxRateData.ApplyDate; }
            set { m_TaxRateData.ApplyDate = value; }
        }
        public int CreateByUserId
        {
            get { return m_TaxRateData.CreatedByUserId; }
            set { m_TaxRateData.CreatedByUserId = value; }
        }
        public int ModifiedByUserId
        {
            get { return m_TaxRateData.ModifiedByUserId; }
            set { m_TaxRateData.ModifiedByUserId = value; }
        }
        public Nullable<bool> IsActive
        {
            get { return m_TaxRateData.IsActive; }
            set { m_TaxRateData.IsActive = value; }
        }
        public TaxRate TaxRateData { get { return m_TaxRateData; } }
    }
}
