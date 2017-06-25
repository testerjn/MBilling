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
    public partial class TaxRateView : KryptonForm, ITaxRateView
    {
        private TaxRatePresenter m_presenter;

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

        private TaxRateSearch _TaxRateSearch;
        public TaxRateSearch MySearch
        {
            get { return _TaxRateSearch; }
            set { _TaxRateSearch = value; }
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
            BindingSource _BindingSource = new BindingSource();
            _BindingSource.DataSource = taxRateViewModelList.ToList();
            grdTaxRste.DataSource = _BindingSource;
            grdTaxRste.ClearSelection();
        }
        public void ShowStateProvince(IEnumerable<StateProvienceModel> lstStateData)
        {
            cmbStateName.DisplayMember = "FullName";
            cmbStateName.ValueMember = "StateId";
            cmbStates.DisplayMember = "FullName";
            cmbStates.ValueMember = "StateId";
            cmbStates.DataSource = new BindingSource(lstStateData, null);
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
            dtApplydate.Value = DateTime.Today;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MyModel.TaxName = stxtName.Text;
            MyModel.StateProvinceId = Convert.ToInt32(cmbStates.SelectedValue.ToString());
            m_presenter.SearchTaxRate();
        }

        private void grdTaxRste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                ClearControls();
                ModelId = Convert.ToInt32(grdTaxRste.Rows[e.RowIndex].Cells["TaxRateId"].Value.ToString());
                m_presenter.EditTaxRateClicked();
                tabNav.SelectedPage = detailTab;
            }
        }

        public void SearchModel(IEnumerable<TaxRateViewModel> taxRateViewModelList)
        {
            grdTaxRste.DataSource = taxRateViewModelList;
        }
        public void ClearControls()
        {
            //throw new NotImplementedException();
        }

        #endregion


    }
}
