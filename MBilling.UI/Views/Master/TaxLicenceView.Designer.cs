namespace MBilling.UI.Views
{
    partial class TaxLicenceView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxLicenceView));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.tabNav = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.lstTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlGridView = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.grdTaxRste = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pnlFind = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.stxtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbStates = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.header1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.taxRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabNav)).BeginInit();
            this.tabNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTab)).BeginInit();
            this.lstTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGridView)).BeginInit();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaxRste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFind)).BeginInit();
            this.pnlFind.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1.Panel)).BeginInit();
            this.header1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxRateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNav
            // 
            this.tabNav.AllowPageReorder = false;
            this.tabNav.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.tabNav.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.OneNote;
            this.tabNav.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.OneNote;
            this.tabNav.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.tabNav.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.tabNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNav.Location = new System.Drawing.Point(0, 0);
            this.tabNav.Name = "tabNav";
            this.tabNav.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.lstTab});
            this.tabNav.SelectedIndex = 0;
            this.tabNav.Size = new System.Drawing.Size(560, 358);
            this.tabNav.TabIndex = 3;
            this.tabNav.Text = "kryptonNavigator1";
            // 
            // lstTab
            // 
            this.lstTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.lstTab.Controls.Add(this.kryptonPanel1);
            this.lstTab.Flags = 65534;
            this.lstTab.LastVisibleSet = true;
            this.lstTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.lstTab.Name = "lstTab";
            this.lstTab.Size = new System.Drawing.Size(558, 327);
            this.lstTab.Text = "List";
            this.lstTab.ToolTipTitle = "Page ToolTip";
            this.lstTab.UniqueName = "708F1E206B764422ECBA560622D160D8";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pnlGridView);
            this.kryptonPanel1.Controls.Add(this.pnlFind);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(558, 327);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.grdTaxRste);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(0, 100);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(558, 227);
            this.pnlGridView.TabIndex = 1;
            // 
            // grdTaxRste
            // 
            this.grdTaxRste.AllowUserToAddRows = false;
            this.grdTaxRste.AllowUserToDeleteRows = false;
            this.grdTaxRste.AllowUserToOrderColumns = true;
            this.grdTaxRste.AllowUserToResizeRows = false;
            this.grdTaxRste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaxRste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTaxRste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdTaxRste.Location = new System.Drawing.Point(0, 0);
            this.grdTaxRste.MultiSelect = false;
            this.grdTaxRste.Name = "grdTaxRste";
            this.grdTaxRste.ReadOnly = true;
            this.grdTaxRste.RowHeadersVisible = false;
            this.grdTaxRste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTaxRste.Size = new System.Drawing.Size(558, 227);
            this.grdTaxRste.TabIndex = 0;
            // 
            // pnlFind
            // 
            this.pnlFind.Controls.Add(this.tableLayoutPanel1);
            this.pnlFind.Controls.Add(this.header1);
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFind.Location = new System.Drawing.Point(0, 0);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(558, 100);
            this.pnlFind.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stxtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbStates, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNew, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 69);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(3, 37);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel6.TabIndex = 2;
            this.kryptonLabel6.Values.Text = "State Name";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(133, 28);
            this.kryptonLabel1.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Name";
            // 
            // stxtName
            // 
            this.stxtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stxtName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.stxtName.Location = new System.Drawing.Point(142, 3);
            this.stxtName.Name = "stxtName";
            this.stxtName.Size = new System.Drawing.Size(133, 20);
            this.stxtName.TabIndex = 0;
            // 
            // cmbStates
            // 
            this.cmbStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStates.DropDownWidth = 191;
            this.cmbStates.Location = new System.Drawing.Point(142, 37);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(133, 21);
            this.cmbStates.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(281, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Values.Text = "&Search";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(281, 37);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 25);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Values.Text = "Add &new";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(420, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Values.Text = "&Clear";
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecHeaderGroup1});
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.header1.HeaderVisibleSecondary = false;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(558, 31);
            this.header1.TabIndex = 1;
            this.header1.ValuesPrimary.Heading = "Find";
            this.header1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("header1.ValuesPrimary.Image")));
            // 
            // buttonSpecHeaderGroup1
            // 
            this.buttonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.buttonSpecHeaderGroup1.UniqueName = "78EF99D45C6842D085B3E55C36D161E6";
            // 
            // taxRateBindingSource
            // 
            this.taxRateBindingSource.DataSource = typeof(MBilling.Common.ViewModels.TaxRateViewModel);
            // 
            // TaxLicenceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 358);
            this.Controls.Add(this.tabNav);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "TaxLicenceView";
            this.Text = "Tax Rate Master";
            this.TextExtra = "Master";
            ((System.ComponentModel.ISupportInitialize)(this.tabNav)).EndInit();
            this.tabNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTab)).EndInit();
            this.lstTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGridView)).EndInit();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTaxRste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFind)).EndInit();
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1)).EndInit();
            this.header1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taxRateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource taxRateBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator tabNav;
        private ComponentFactory.Krypton.Navigator.KryptonPage lstTab;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox stxtName;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup header1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdTaxRste;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbStates;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddNew;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
    }
}