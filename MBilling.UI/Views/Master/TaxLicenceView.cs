using ComponentFactory.Krypton.Toolkit;
using MBilling.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MBilling.Common.ViewModels;
using MBilling.DataAcces.Models;
using MBilling.Core.Domain;
using MBilling.Business.Presenters;

namespace MBilling.UI.Views
{
    public partial class TaxLicenceView : KryptonForm
    {

        #region Constructor
        public TaxLicenceView()
        {
            InitializeComponent();
        }

        public TaxLicenceView(int UserId, TaxRateDao dao) : this()
        {

        }
        #endregion

        

        


    }
}
