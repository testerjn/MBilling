using MBilling.Business.Business;
using MBilling.Common.Interfaces;
using MBilling.Common.ViewModels;
using MBilling.Core;
using MBilling.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Business.Presenters
{
    public class TaxRatePresenter
    {
        private ITaxRateView m_view = null;
        private TaxRateDao m_taxRateDao = new TaxRateDao();
        private StateProvinceDao m_stateProvinceDao = new StateProvinceDao();
        private TaxRateViewModel m_viewModel;
        private IEnumerable<TaxRateViewModel> m_TaxRateViewModelList;
        private IEnumerable<StateProvienceModel> m_StateViewModelList;

        public TaxRatePresenter(ITaxRateView p_view)
        {
            m_view = p_view;
            PopulateData();
            TaxRate taxRateDataEntity = new TaxRate();
            TaxRateViewModel taxRateViewModel = new TaxRateViewModel(taxRateDataEntity);
            m_view.MyModel = taxRateViewModel;
            m_view.ShowModel(taxRateViewModel);
        }
        public TaxRatePresenter(ITaxRateView p_view, TaxRateDao p_taxRateDao)
        {
            m_view = p_view;
            m_taxRateDao = p_taxRateDao;
        }
        private void PopulateData()
        {
            GetAllTaxRate();
            GetAllStateProvince();
        }
        private async void GetAllTaxRate()
        {
            IEnumerable<TaxRate> taxRateEntityList = await m_taxRateDao.GetAll();

            IEnumerable<TaxRateViewModel> taxRateViewModel =
                ResolveViewModelArray(taxRateEntityList);

            m_TaxRateViewModelList = taxRateViewModel;

            m_view.GetAll(m_TaxRateViewModelList);
        }
        private async void GetAllStateProvince()
        {
            IEnumerable<StateProvince> stateEntityList = await m_stateProvinceDao.GetAll();
            IEnumerable<StateProvienceModel> stateViewModel = ObjectExtensions.ResolveViewModel<IEnumerable<StateProvienceModel>>(stateEntityList);
                //SResolveViewModelArray(stateEntityList);
            m_StateViewModelList = stateViewModel;
           
            m_view.ShowStateProvince(m_StateViewModelList);
        }
        private IEnumerable<TaxRateViewModel> ResolveViewModelArray(IEnumerable<TaxRate> taxRateEntityList)
        {
            foreach (TaxRate taxRateEntity in taxRateEntityList)
            {
                yield return new TaxRateViewModel(taxRateEntity);
            }
        }

        private IEnumerable<StateProvienceModel> SResolveViewModelArray(IEnumerable<StateProvince> taxRateEntityList)
        {
            foreach (StateProvince taxRateEntity in taxRateEntityList)
            {
                yield return new StateProvienceModel(taxRateEntity);
            }
        }


        public async void SearchTaxRate()
        {
            m_viewModel = m_view.MyModel;
            IEnumerable<TaxRate> taxRateEntityList = await m_taxRateDao.GetAllBy(x => x.TaxName.Contains(m_viewModel.TaxName));

            IEnumerable<TaxRateViewModel> taxRateViewModel =
                ResolveViewModelArray(taxRateEntityList);

            m_TaxRateViewModelList = taxRateViewModel;

            m_view.GetAll(m_TaxRateViewModelList);
        }

        public async void EditTaxRateClicked()
        {
            TaxRate taxRateEntity = await m_taxRateDao.GetById(m_view.ModelId);
            m_viewModel = new TaxRateViewModel(taxRateEntity);
            m_view.ShowModel(m_viewModel);
        }
        public void AddTaxRateClicked()
        {
            TaxRate taxRateDataEntity = new TaxRate();
            m_viewModel = new TaxRateViewModel(taxRateDataEntity);
            m_view.ShowModel(m_viewModel);
        }
        public void AddTaxRate()
        {
            TaxRate taxRateDataEntity = new TaxRate();
            TaxRateViewModel taxRateViewModel = new TaxRateViewModel(taxRateDataEntity);
        }
        public void SaveClicked()
        {
            m_view.ReadUserInput();
            TaxRate taxRateDataEntity = m_viewModel.TaxRateData;
            List<string> lstMessages = new List<string>();
            bool isValid = m_taxRateDao.Validate(taxRateDataEntity, out lstMessages);
            if (isValid)
            {
                if (taxRateDataEntity.TaxRateId == 0)
                {
                    m_taxRateDao.Insert(taxRateDataEntity);
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
