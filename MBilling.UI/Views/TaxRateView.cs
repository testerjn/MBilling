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

        #region Properties
        public string Message
        {
            get; set;
        }
        private TaxRateViewModel _TaxRateViewModel;
        public TaxRateViewModel MyModel
        {
            get { return _TaxRateViewModel; }
            set { _TaxRateViewModel = value; }
        }

        public string Title
        {
            get; set;
        }
        #endregion

        #region Constructor
        public TaxRateView()
        {
            InitializeComponent();
            m_presenter = new TaxRatePresenter(this);
        }

        public TaxRateView(int UserId, TaxRateDao dao) : this()
        {

            m_presenter = new TaxRatePresenter(this, dao);
        }
        #endregion

        #region Method
        public void GetAll(IEnumerable<TaxRateViewModel> taxRateViewModelList)
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

        public void ShowModel(TaxRateViewModel taxRateViewModel)
        {
            taxRateBindingSource.DataSource = taxRateViewModel;
        }

        public void ShowError()
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

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

        private void grdTaxRste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                ClearControls();
                tabNav.SelectedPage = detailTab;
                MyModel = grdTaxRste.SelectedRows.Cast<TaxRateViewModel>().FirstOrDefault();
                m_presenter.EditTaxRateClicked();
            }
        }

        public void SearchModel(IEnumerable<TaxRateViewModel> taxRateViewModelList)
        {
            grdTaxRste.DataSource = taxRateViewModelList;
        }
        public void ClearControls()
        {
            throw new NotImplementedException();
        }

        #endregion

     
    }
}
