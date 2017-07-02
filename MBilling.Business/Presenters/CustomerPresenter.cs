using MBilling.Common.Interfaces;
using MBilling.Common.ViewModels;
using MBilling.Core;
using MBilling.Core.Domain;
using MBilling.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Business.Presenters
{
    public class CustomerPresenter
    {
        private ICustomerView m_view = null;
        private PersonDao m_PersonDao = new PersonDao();
        private AddressDao m_addressDao = new AddressDao();
        private CustomerViewModel m_viewModel;
        private IEnumerable<CustomerViewModel> m_CustomerViewModelList;
        private IEnumerable<AddressViewModel> m_AddressViewModelList;

        public CustomerPresenter(ICustomerView p_view)
        {
            m_view = p_view;
            PopulateData();
            Customer customerDataEntity = new Customer();
            CustomerViewModel customerViewModel = new CustomerViewModel(customerDataEntity);
            m_view.MyModel = customerViewModel;
            m_view.ShowModel(customerViewModel);
        }

        public CustomerPresenter(ICustomerView p_view, PersonDao p_personDao)
        {
            m_view = p_view;
            m_PersonDao = p_personDao;
        }

        private void PopulateData()
        {
           //GetAllTaxRate();
           //GetAllStateProvince();
        }

        private async void GetAllCustomer()
        {
            IEnumerable<Person> personEntityList = await m_PersonDao.GetAllBy(x => x.PersonTypeId == PersonTypeEnum.Customer);
            IEnumerable<Customer> customerEntityList = personEntityList as IEnumerable<Customer>;

            IEnumerable<CustomerViewModel> customerViewModel = ResolveViewModelArray(customerEntityList);

            m_CustomerViewModelList = customerViewModel;

            m_view.GetAll(m_CustomerViewModelList);
        }
        private async void GetAllStateProvince()
        {
            //IEnumerable<StateProvince> stateEntityList = await m_stateProvinceDao.GetAll();
            //IEnumerable<StateProvienceModel> stateViewModel =
            //    SResolveViewModelArray(stateEntityList);
            //m_StateViewModelList = stateViewModel;

            //m_view.ShowStateProvince(m_StateViewModelList);
        }

        public async void SearchCustomer()
        {
            m_viewModel = m_view.MyModel;
            IEnumerable<Customer> customerEntityList = await m_taxRateDao.GetAllBy(x => x.TaxName.Contains(m_viewModel.TaxName));

            IEnumerable<TaxRateViewModel> taxRateViewModel =ResolveViewModelArray(customerEntityList);

            m_CustomerViewModelList = taxRateViewModel;

            m_view.GetAll(m_CustomerViewModelList);
        }

        public async void EditCustomerClicked()
        {
            Customer customerEntity = await m_PersonDao.GetById(m_view.ModelId);
            m_viewModel = new CustomerViewModel(customerEntity);
            m_view.ShowModel(m_viewModel);
        }
        public void AddCustomerClicked()
        {
            Customer customerDataEntity = new Customer();
            m_viewModel = new CustomerViewModel(customerDataEntity);
            m_view.ShowModel(m_viewModel);
        }
        public void AddCustomer()
        {
            Customer customerDataEntity = new Customer();
            CustomerViewModel customerViewModel = new CustomerViewModel(customerDataEntity);
        }
        public void SaveClicked()
        {
            m_view.ReadUserInput();
            Customer customerDataEntity = m_viewModel.TaxRateData;
            List<string> lstMessages = new List<string>();
            bool isValid = m_taxRateDao.Validate(customerDataEntity, out lstMessages);
            if (isValid)
            {
                if (customerDataEntity.PersonId == 0)
                {
                    m_taxRateDao.Insert(customerDataEntity);
                }
                else
                {
                    m_taxRateDao.Update(taxRateDataEntity);
                }
                GetAllTaxRate();
            }
            else
            {
                string strMessages = String.Join(Environment.NewLine, lstMessages.Select(a => a.ToString()));
                m_view.Message = strMessages;
                m_view.ShowError();
            }
        }

        public void CancellClicked()
        {
            m_view.Close();
        }
    }
}
