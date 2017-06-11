using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class TaxRateViewModel : INotifyPropertyChanged
    {
        private readonly TaxRate m_TaxRateData;

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public TaxRateViewModel(TaxRate _TaxRate)
        {
            m_TaxRateData = _TaxRate;
        }
        public int StateProvinceId
        {
            get { return m_TaxRateData.StateProvinceId; }
            set
            {
                if (value != m_TaxRateData.StateProvinceId)
                {
                    m_TaxRateData.StateProvinceId = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public Nullable<byte> TaxType
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
        public Nullable<int> CreateByUserId
        {
            get { return m_TaxRateData.CreateByUserId; }
            set { m_TaxRateData.CreateByUserId = value; }
        }
        public Nullable<int> ModifiedByUserId
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
