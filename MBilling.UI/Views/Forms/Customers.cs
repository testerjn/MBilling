using ComponentFactory.Krypton.Toolkit;
using MBilling.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBilling.Common.ViewModels;
using MBilling.Business.Presenters;
using MBilling.Business.Business;
using MBilling.DataAcces.Models;

namespace MBilling.UI.Views.Forms
{
    public partial class Customers : KryptonForm, ICustomerView
    {

        private CustomerPresenter m_presenter;

        #region Properties
        private int _SelectdModelId;

        public int ModelId
        {
            get { return _SelectdModelId; }
            set { _SelectdModelId = value; }
        }

        public string Message
        {
            get; set;
        }

        private CustomerViewModel _CustomerViewModel;

        public CustomerViewModel MyModel
        {
            get { return _CustomerViewModel; }
            set { _CustomerViewModel = value; }
        }

        public string Title
        {
            get; set;
        }
        #endregion

        #region Constructor
        public Customers()
        {
            InitializeComponent();
            m_presenter = new CustomerPresenter(this);
        }

        public Customers(int UserId, PersonDao dao) : this()
        {

            m_presenter = new CustomerPresenter(this, dao);
        }

        #endregion

        #region Method, Function
        public void PopulateAddressType(List<string> lstAddressTypeEnumData)
        {
            cmbAddressType.DataSource = lstAddressTypeEnumData;
        }

        public void GetAll(IEnumerable<CustomerViewModel> modelList)
        {
            BindingSource _BindingSource = new BindingSource();
            _BindingSource.DataSource = modelList.ToList();
            grdTaxRste.DataSource = _BindingSource;
            grdTaxRste.ClearSelection();
        }

        public void ShowAddress(IEnumerable<AddressViewModel> lstAddressData)
        {
            if (lstAddressData != null)
            {
                if (lstAddressData.ToList().Count > 0)
                {
                    foreach (AddressViewModel item in lstAddressData.ToList())
                    {
                        //fill control on psge tab
                    }
                }
            }
        }

        public void SearchModel(IEnumerable<CustomerViewModel> modelList)
        {
            grdTaxRste.DataSource = modelList;
        }

        public void ShowError()
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowModel(CustomerViewModel myModel)
        {
            customerBindingSource.DataSource = myModel;
        }

        public void ClearControls()
        {
            //   throw new NotImplementedException();
        }

        public void ReadUserInput()
        {
            customerBindingSource.EndEdit();
        }
        #endregion

        #region Page Events

        #endregion

        private void btnaddaddress_Click(object sender, EventArgs e)
        {

        }
    }


}

