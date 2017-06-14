﻿using MBilling.Common.Interfaces;
using MBilling.Common.ViewModels;
using MBilling.Core.Data;
using MBilling.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.UI.Presenters
{
    public class TaxRatePresenter
    {
        private ITaxRateView m_view = null;
        private TaxRateDao m_taxRateDao;
        private TaxRateViewModel m_viewModel;
        private IEnumerable<TaxRateViewModel> m_TaxRateViewModelList;
        private Dictionary<int, string> m_StateViewModelList;

        public TaxRatePresenter(ITaxRateView p_view)
        {
            m_view = p_view;
            PopulateData();
            TaxRate taxRateDataEntity = new TaxRate();
            TaxRateViewModel taxRateViewModel = new TaxRateViewModel(taxRateDataEntity);
            m_view.ShowTaxRate(taxRateViewModel);
        }
        public TaxRatePresenter(ITaxRateView p_view, TaxRateDao p_taxRateDao)
        {
            m_view = p_view;
            m_taxRateDao = p_taxRateDao;

            //TaxRate taxRateDataEntity = new TaxRate();
            //TaxRateViewModel taxRateViewModel = new TaxRateViewModel(taxRateDataEntity);

            //m_viewModel = taxRateViewModel;
            //m_view.ShowTaxRate(taxRateViewModel);
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

            m_view.ShowAllTaxRate(m_TaxRateViewModelList);
        }
        private void GetAllStateProvince()
        {
            Dictionary<int, string> s1 = new Dictionary<int, string>();
            s1.Add(1,"MH");
            s1.Add(2, "GJ");
            s1.Add(3, "MP");
            s1.Add(4, "UP");
            s1.Add(5, "KN");

            m_StateViewModelList = s1;
            m_view.ShowStateProvince(m_StateViewModelList);
        }
        private IEnumerable<TaxRateViewModel> ResolveViewModelArray(IEnumerable<TaxRate> taxRateEntityList)
        {
            foreach (TaxRate taxRateEntity in taxRateEntityList)
            {
                yield return new TaxRateViewModel(taxRateEntity);
            }
        }


        public async void SearchTaxRate()
        {
            IEnumerable<TaxRate> taxRateEntityList = await m_taxRateDao.GetAll();

            IEnumerable<TaxRateViewModel> taxRateViewModel =
                ResolveViewModelArray(taxRateEntityList);

            m_TaxRateViewModelList = taxRateViewModel;

            m_view.ShowAllTaxRate(m_TaxRateViewModelList);
        }

        public void AddTaxRateClicked()
        {
            TaxRate taxRateDataEntity = new TaxRate();
            m_viewModel = new TaxRateViewModel(taxRateDataEntity);
            m_view.ShowTaxRate(m_viewModel);
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
            }
            else
            {
                string strMessages = String.Join(Environment.NewLine, lstMessages.Select(a => a.ToString()));
                m_view.ShowError(strMessages);
            }
        }

        public void CancellClicked()
        {
            m_view.Close();
        }
    }
}