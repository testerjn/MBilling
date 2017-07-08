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
            this.detailTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlGridView = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.grdTaxRste = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pnlFind = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.header1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.stxtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabNav)).BeginInit();
            this.tabNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTab)).BeginInit();
            this.lstTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailTab)).BeginInit();
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
            this.tabNav.SelectedIndex = 0;
            this.tabNav.Size = new System.Drawing.Size(568, 397);
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
            // detailTab
            // 
            this.detailTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.detailTab.Flags = 65534;
            this.detailTab.LastVisibleSet = true;
            this.detailTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.detailTab.Name = "detailTab";
            this.detailTab.Size = new System.Drawing.Size(566, 366);
            this.detailTab.Text = "Detail";
            this.detailTab.ToolTipTitle = "Page ToolTip";
            this.detailTab.UniqueName = "D25B46F2E2DD4183BD8D1BDA7F604C57";
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
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 397);
            this.Controls.Add(this.tabNav);
            this.Name = "Customers";
            this.Text = "Customers";
            this.TextExtra = "";
            ((System.ComponentModel.ISupportInitialize)(this.tabNav)).EndInit();
            this.tabNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTab)).EndInit();
            this.lstTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailTab)).EndInit();
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
    }
}