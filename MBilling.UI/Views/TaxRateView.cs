using ComponentFactory.Krypton.Toolkit;
using MBilling.Common.Interfaces;
using MBilling.UI.Presenters;
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
using MBilling.DataAcces.Models;

namespace MBilling.UI.Views
{
    public partial class TaxRateView : KryptonForm, ITaxRateView
    {
        private TaxRatePresenter m_presenter;

        public TaxRateView()
        {
            InitializeComponent();
            m_presenter = new TaxRatePresenter(this);
        }

        public TaxRateView(int UserId, TaxRateDao dao) : this()
        {

            m_presenter = new TaxRatePresenter(this, dao);
        }

        public void ShowAllTaxRate(IEnumerable<TaxRateViewModel> taxRateViewModelList)
        {
            grdTaxRste.DataSource = taxRateViewModelList;
        }
        public void ShowStateProvince(Dictionary<int, string> lstStateData)
        {
            cmbStateName.DisplayMember = "FullName";
            cmbStateName.ValueMember = "StateId";
            cmbStateName.DataSource = new BindingSource(lstStateData, null); 
            cmbStateName.DataSource = new BindingSource(lstStateData, null);
        }

        public void ReadUserInput()
        {
            taxRateBindingSource.EndEdit();
        }
        public void ReadUserInput(TaxRateViewModel taxRateViewModel)
        {
            taxRateViewModel.TaxName = txtTaxName.Text;
            taxRateViewModel.ApplyDate = dtApplydate.Value;
            taxRateViewModel.TaxRate1 = nmTaxRate.Value;
            taxRateViewModel.IsActive = chkActive.Checked;
            taxRateViewModel.StateProvinceId = (int)cmbStateName.SelectedValue;
            taxRateViewModel.CreateByUserId = 1;
            taxRateViewModel.ModifiedByUserId = 1;
        }

        public void ShowTaxRate(TaxRateViewModel taxRateViewModel)
        {
            taxRateBindingSource.DataSource = taxRateViewModel;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            m_presenter.SaveClicked();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_presenter.CancellClicked();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tabNav.SelectedPage = detailTab;
            m_presenter.AddTaxRateClicked();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            m_presenter.SearchTaxRate();
        }

        #endregion
    }
}
