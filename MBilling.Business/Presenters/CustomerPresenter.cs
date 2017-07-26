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
            GetAllCustomer();
            //GetAllStateProvince();
            GetAllAddressType();
        }

        private void GetAllAddressType()
        {
            List<string> stateEntityList = Enum.GetNames(typeof(AddressTypeEnum)).ToList();
            m_view.PopulateAddressType(stateEntityList);
        }

        private async void GetAllCustomer()
        {
            IEnumerable<Person> personEntityList = await m_PersonDao.GetAllBy(x => x.PersonTypeId == PersonTypeEnum.Customer);
            IEnumerable<Customer> customerEntityList = personEntityList as IEnumerable<Customer>;

            IEnumerable<CustomerViewModel> customerViewModel = ResolveViewModelArray(customerEntityList);

            m_CustomerViewModelList = customerViewModel;

            m_view.GetAll(m_CustomerViewModelList);
        }

        private IEnumerable<CustomerViewModel> ResolveViewModelArray(IEnumerable<Customer> customerEntityList)
        {
            if (customerEntityList != null)
            {
                foreach (Customer CustomerEntity in customerEntityList)
                {
                    yield return new CustomerViewModel(CustomerEntity);
                }
            }
            else
            {
                new CustomerViewModel(new Customer());
            }
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

            IEnumerable<CustomerViewModel> customerEntitylst = m_CustomerViewModelList.Where(x => x.Name.Contains(m_viewModel.Name)).ToList();
            m_CustomerViewModelList = customerEntitylst;
            m_view.GetAll(m_CustomerViewModelList);
        }

        public async void EditCustomerClicked()
        {
            m_viewModel = m_CustomerViewModelList.Where(x => x.PersonId == m_view.ModelId).FirstOrDefault();
            m_view.ShowModel(m_viewModel);
        }
        public void AddCustomerClicked()
        {
            Customer customerDataEntity = new Customer();
            m_viewModel = new CustomerViewModel(customerDataEntity);
            m_view.ShowModel(m_viewModel);
        }

        private void AddNewAddress(string strAddressType)
        {
            AddressTypeEnum addtype = (AddressTypeEnum)Enum.Parse(typeof(AddressTypeEnum), strAddressType);
        }
        public void AddCustomer()
        {
            Customer customerDataEntity = new Customer();
            CustomerViewModel customerViewModel = new CustomerViewModel(customerDataEntity);
        }
        public void SaveClicked()
        {
            m_view.ReadUserInput();
            Customer customerDataEntity = m_viewModel.CustomerData;
            List<string> lstMessages = new List<string>();
            bool isValid = m_PersonDao.Validate(customerDataEntity, out lstMessages);
            if (isValid)
            {
                Person mypersonEntity = customerDataEntity as Person;
                if (customerDataEntity.PersonId == 0)
                {
                    m_PersonDao.Insert(mypersonEntity);
                }
                else
                {
                    m_PersonDao.Update(mypersonEntity);
                }
                GetAllCustomer();
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
