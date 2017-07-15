namespace MBilling.UI.Views.Forms
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.tabNav = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.lstTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlGridView = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.grdTaxRste = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pnlFind = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.stxtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.header1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.detailTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.officeTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbStateName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.usrContactDetail1 = new MBilling.UI.Views.UserControls.usrContactDetail();
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
            ((System.ComponentModel.ISupportInitialize)(this.header1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1.Panel)).BeginInit();
            this.header1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailTab)).BeginInit();
            this.detailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStateName)).BeginInit();
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
            this.lstTab,
            this.detailTab});
            this.tabNav.SelectedIndex = 1;
            this.tabNav.Size = new System.Drawing.Size(580, 527);
            this.tabNav.TabIndex = 4;
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
            this.lstTab.Size = new System.Drawing.Size(566, 366);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(566, 366);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.grdTaxRste);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(0, 100);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(566, 266);
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
            this.grdTaxRste.Size = new System.Drawing.Size(566, 266);
            this.grdTaxRste.TabIndex = 0;
            // 
            // pnlFind
            // 
            this.pnlFind.Controls.Add(this.tableLayoutPanel1);
            this.pnlFind.Controls.Add(this.header1);
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFind.Location = new System.Drawing.Point(0, 0);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(566, 100);
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
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stxtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNew, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 69);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(135, 28);
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
            this.stxtName.Location = new System.Drawing.Point(144, 3);
            this.stxtName.Name = "stxtName";
            this.stxtName.Size = new System.Drawing.Size(135, 20);
            this.stxtName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(285, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Values.Text = "&Search";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(285, 37);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 25);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Values.Text = "Add &new";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(426, 3);
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
            this.header1.Size = new System.Drawing.Size(566, 31);
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
            this.detailTab.Size = new System.Drawing.Size(578, 496);
            this.detailTab.Text = "Detail";
            this.detailTab.ToolTipTitle = "Page ToolTip";
            this.detailTab.UniqueName = "D25B46F2E2DD4183BD8D1BDA7F604C57";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.usrContactDetail1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(578, 496);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.btnCancel);
            this.kryptonPanel4.Controls.Add(this.btnSave);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 456);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(578, 40);
            this.kryptonPanel4.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Values.Text = "&Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Values.Text = "&Save";
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 100);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.officeTab});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(578, 221);
            this.kryptonNavigator1.TabIndex = 17;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // officeTab
            // 
            this.officeTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.officeTab.Flags = 65534;
            this.officeTab.LastVisibleSet = true;
            this.officeTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.officeTab.Name = "officeTab";
            this.officeTab.Size = new System.Drawing.Size(576, 194);
            this.officeTab.Text = "Office";
            this.officeTab.ToolTipTitle = "Page ToolTip";
            this.officeTab.UniqueName = "7CADD57EC85C4A93C0B352A71A177269";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel3.Controls.Add(this.kryptonTextBox2);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel3.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel3.Controls.Add(this.cmbStateName);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel3.Controls.Add(this.txtName);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(578, 100);
            this.kryptonPanel3.TabIndex = 16;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(410, 5);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(147, 21);
            this.kryptonDateTimePicker1.TabIndex = 16;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 3);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "Customer Code:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(299, 29);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(89, 20);
            this.kryptonLabel7.TabIndex = 12;
            this.kryptonLabel7.Values.Text = "Payment Term";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(411, 29);
            this.kryptonTextBox2.Multiline = true;
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(163, 40);
            this.kryptonTextBox2.TabIndex = 14;
            this.kryptonTextBox2.WordWrap = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 73);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(84, 20);
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Address Type";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(116, 3);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(71, 20);
            this.kryptonTextBox1.TabIndex = 13;
            // 
            // cmbStateName
            // 
            this.cmbStateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStateName.DropDownWidth = 191;
            this.cmbStateName.Location = new System.Drawing.Point(116, 73);
            this.cmbStateName.Name = "cmbStateName";
            this.cmbStateName.Size = new System.Drawing.Size(167, 21);
            this.cmbStateName.TabIndex = 15;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(299, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(104, 20);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Registration date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 29);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 40);
            this.txtName.TabIndex = 5;
            this.txtName.WordWrap = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 29);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Name";
            // 
            // usrContactDetail1
            // 
            this.usrContactDetail1.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrContactDetail1.Location = new System.Drawing.Point(0, 321);
            this.usrContactDetail1.Name = "usrContactDetail1";
            this.usrContactDetail1.Size = new System.Drawing.Size(578, 89);
            this.usrContactDetail1.TabIndex = 19;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 527);
            this.Controls.Add(this.tabNav);
            this.Name = "Customers";
            this.Text = "Customers";
            this.TextExtra = "";
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
            ((System.ComponentModel.ISupportInitialize)(this.header1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1)).EndInit();
            this.header1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailTab)).EndInit();
            this.detailTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStateName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator tabNav;
        private ComponentFactory.Krypton.Navigator.KryptonPage lstTab;
        private ComponentFactory.Krypton.Navigator.KryptonPage detailTab;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdTaxRste;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox stxtName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddNew;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup header1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbStateName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage officeTab;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private UserControls.usrContactDetail usrContactDetail1;
    }
}