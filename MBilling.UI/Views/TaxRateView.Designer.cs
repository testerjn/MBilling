namespace MBilling.UI.Views
{
    partial class TaxRateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxRateView));
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
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbStates = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.header1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.detailTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTaxName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.taxRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nmTaxRate = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.dtApplydate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.chkActive = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cmbStateName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.detailTab)).BeginInit();
            this.detailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStateName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNav
            // 
            this.tabNav.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.OneNote;
            this.tabNav.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.OneNote;
            this.tabNav.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.tabNav.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.tabNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNav.Location = new System.Drawing.Point(0, 0);
            this.tabNav.Name = "tabNav";
            this.tabNav.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.lstTab,
            this.detailTab});
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
            this.grdTaxRste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaxRste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTaxRste.Location = new System.Drawing.Point(0, 0);
            this.grdTaxRste.Name = "grdTaxRste";
            this.grdTaxRste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTaxRste.Size = new System.Drawing.Size(558, 227);
            this.grdTaxRste.TabIndex = 0;
            this.grdTaxRste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTaxRste_CellContentClick);
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
            this.tableLayoutPanel1.Controls.Add(this.kryptonTextBox1, 1, 0);
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
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonTextBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonTextBox1.Location = new System.Drawing.Point(142, 3);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(133, 20);
            this.kryptonTextBox1.TabIndex = 1;
            // 
            // cmbStates
            // 
            this.cmbStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStates.DropDownWidth = 191;
            this.cmbStates.Location = new System.Drawing.Point(142, 37);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(133, 21);
            this.cmbStates.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(281, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Values.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(281, 37);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 25);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Values.Text = "Add &new";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(420, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 25);
            this.btnClear.TabIndex = 10;
            this.btnClear.Values.Text = "&Clear";
            this.btnClear.Click += new System.EventHandler(this.btnCancel_Click);
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
            // detailTab
            // 
            this.detailTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.detailTab.Controls.Add(this.kryptonPanel2);
            this.detailTab.Flags = 65534;
            this.detailTab.LastVisibleSet = true;
            this.detailTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.detailTab.Name = "detailTab";
            this.detailTab.Size = new System.Drawing.Size(558, 327);
            this.detailTab.Text = "Detail";
            this.detailTab.ToolTipTitle = "Page ToolTip";
            this.detailTab.UniqueName = "D25B46F2E2DD4183BD8D1BDA7F604C57";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.tableLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(558, 327);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.26882F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.73118F));
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.kryptonLabel5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTaxName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nmTaxRate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtApplydate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.chkActive, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cmbStateName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.kryptonPanel3, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(558, 327);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Name";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 49);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "State Name";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 95);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Tax Rate";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 141);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel5.TabIndex = 3;
            this.kryptonLabel5.Values.Text = "Apply Date";
            // 
            // txtTaxName
            // 
            this.txtTaxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taxRateBindingSource, "TaxName", true));
            this.txtTaxName.Location = new System.Drawing.Point(144, 3);
            this.txtTaxName.Name = "txtTaxName";
            this.txtTaxName.Size = new System.Drawing.Size(265, 20);
            this.txtTaxName.TabIndex = 5;
            // 
            // taxRateBindingSource
            // 
            this.taxRateBindingSource.DataSource = typeof(MBilling.Common.ViewModels.TaxRateViewModel);
            // 
            // nmTaxRate
            // 
            this.nmTaxRate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taxRateBindingSource, "TaxRate1", true));
            this.nmTaxRate.Location = new System.Drawing.Point(144, 95);
            this.nmTaxRate.Name = "nmTaxRate";
            this.nmTaxRate.Size = new System.Drawing.Size(191, 22);
            this.nmTaxRate.TabIndex = 7;
            // 
            // dtApplydate
            // 
            this.dtApplydate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taxRateBindingSource, "ApplyDate", true));
            this.dtApplydate.Location = new System.Drawing.Point(144, 141);
            this.dtApplydate.Name = "dtApplydate";
            this.dtApplydate.Size = new System.Drawing.Size(191, 21);
            this.dtApplydate.TabIndex = 8;
            // 
            // chkActive
            // 
            this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.taxRateBindingSource, "IsActive", true));
            this.chkActive.Location = new System.Drawing.Point(144, 187);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(69, 20);
            this.chkActive.TabIndex = 9;
            this.chkActive.Values.Text = "Is Active";
            // 
            // cmbStateName
            // 
            this.cmbStateName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taxRateBindingSource, "StateProvinceId", true));
            this.cmbStateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStateName.DropDownWidth = 191;
            this.cmbStateName.Location = new System.Drawing.Point(144, 49);
            this.cmbStateName.Name = "cmbStateName";
            this.cmbStateName.Size = new System.Drawing.Size(191, 21);
            this.cmbStateName.TabIndex = 6;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnCancel);
            this.kryptonPanel3.Controls.Add(this.btnSave);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(144, 233);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(411, 40);
            this.kryptonPanel3.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Values.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Values.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TaxRateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 358);
            this.Controls.Add(this.tabNav);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "TaxRateView";
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
            ((System.ComponentModel.ISupportInitialize)(this.detailTab)).EndInit();
            this.detailTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStateName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup header1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup1;
        private ComponentFactory.Krypton.Navigator.KryptonPage detailTab;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdTaxRste;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTaxName;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nmTaxRate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtApplydate;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkActive;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbStateName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbStates;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddNew;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
    }
}