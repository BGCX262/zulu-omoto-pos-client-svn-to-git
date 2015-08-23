namespace ZuluPOSClient.Products
{
    partial class frmCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.pnlCategory = new System.Windows.Forms.Panel();
			this.grdCategory = new DevExpress.XtraGrid.GridControl();
			this.grdCategoryView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.grdColCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.gridColCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCategory = new DevExpress.XtraEditors.TextEdit();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
			this.cmdNew = new ZuluPOSClient.Controls.BaseZuluButtonControl();
			this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnlCategory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCategoryView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.lblExit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1372, 32);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Location = new System.Drawing.Point(636, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 26);
			this.label1.TabIndex = 8;
			this.label1.Text = "Category";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(6, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// lblExit
			// 
			this.lblExit.ActiveLinkColor = System.Drawing.Color.Crimson;
			this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblExit.AutoSize = true;
			this.lblExit.Font = new System.Drawing.Font("Myriad Web Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExit.ForeColor = System.Drawing.Color.Orange;
			this.lblExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lblExit.LinkColor = System.Drawing.Color.Orange;
			this.lblExit.Location = new System.Drawing.Point(1332, 9);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(32, 17);
			this.lblExit.TabIndex = 1;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "E&xit";
			this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// pnlCategory
			// 
			this.pnlCategory.Controls.Add(this.grdCategory);
			this.pnlCategory.Controls.Add(this.chkIsActive);
			this.pnlCategory.Controls.Add(this.label2);
			this.pnlCategory.Controls.Add(this.txtCategory);
			this.pnlCategory.Controls.Add(this.panel3);
			this.pnlCategory.Location = new System.Drawing.Point(178, 33);
			this.pnlCategory.Name = "pnlCategory";
			this.pnlCategory.Size = new System.Drawing.Size(1024, 729);
			this.pnlCategory.TabIndex = 1;
			// 
			// grdCategory
			// 
			this.grdCategory.Location = new System.Drawing.Point(12, 147);
			this.grdCategory.MainView = this.grdCategoryView;
			this.grdCategory.Name = "grdCategory";
			this.grdCategory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive});
			this.grdCategory.Size = new System.Drawing.Size(1001, 526);
			this.grdCategory.TabIndex = 34;
			this.grdCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCategoryView});
			// 
			// grdCategoryView
			// 
			this.grdCategoryView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.grdCategoryView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.grdCategoryView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdCategoryView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.grdCategoryView.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.grdCategoryView.Appearance.HeaderPanel.Options.UseBorderColor = true;
			this.grdCategoryView.Appearance.HeaderPanel.Options.UseFont = true;
			this.grdCategoryView.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.grdCategoryView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.grdCategoryView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColCategoryID,
            this.grdColName,
            this.grdColIsActive,
            this.gridColCreatedOn});
			this.grdCategoryView.GridControl = this.grdCategory;
			this.grdCategoryView.Name = "grdCategoryView";
			this.grdCategoryView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.grdCategoryView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.grdCategoryView.OptionsCustomization.AllowColumnMoving = false;
			this.grdCategoryView.OptionsCustomization.AllowColumnResizing = false;
			this.grdCategoryView.OptionsView.EnableAppearanceEvenRow = true;
			this.grdCategoryView.OptionsView.ShowGroupExpandCollapseButtons = false;
			this.grdCategoryView.OptionsView.ShowGroupPanel = false;
			this.grdCategoryView.PaintStyleName = "UltraFlat";
			this.grdCategoryView.RowHeight = 25;
			this.grdCategoryView.ViewCaptionHeight = 38;
			this.grdCategoryView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grdCategoryView_RowCellClick);
			// 
			// grdColCategoryID
			// 
			this.grdColCategoryID.Caption = "CategoryID";
			this.grdColCategoryID.FieldName = "CategoryID";
			this.grdColCategoryID.Name = "grdColCategoryID";
			// 
			// grdColName
			// 
			this.grdColName.Caption = "Category";
			this.grdColName.FieldName = "Name";
			this.grdColName.Name = "grdColName";
			this.grdColName.OptionsColumn.AllowEdit = false;
			this.grdColName.Visible = true;
			this.grdColName.VisibleIndex = 0;
			this.grdColName.Width = 491;
			// 
			// grdColIsActive
			// 
			this.grdColIsActive.Caption = "Is Active";
			this.grdColIsActive.ColumnEdit = this.repositoryItemChkIsActive;
			this.grdColIsActive.FieldName = "Published";
			this.grdColIsActive.Name = "grdColIsActive";
			this.grdColIsActive.OptionsColumn.AllowEdit = false;
			this.grdColIsActive.Visible = true;
			this.grdColIsActive.VisibleIndex = 1;
			this.grdColIsActive.Width = 100;
			// 
			// repositoryItemChkIsActive
			// 
			this.repositoryItemChkIsActive.AutoHeight = false;
			this.repositoryItemChkIsActive.Name = "repositoryItemChkIsActive";
			// 
			// gridColCreatedOn
			// 
			this.gridColCreatedOn.Caption = "CreatedOn";
			this.gridColCreatedOn.FieldName = "CreatedOn";
			this.gridColCreatedOn.Name = "gridColCreatedOn";
			// 
			// chkIsActive
			// 
			this.chkIsActive.Location = new System.Drawing.Point(191, 99);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkIsActive.Properties.Appearance.Options.UseFont = true;
			this.chkIsActive.Properties.Caption = "IsActive";
			this.chkIsActive.Size = new System.Drawing.Size(75, 21);
			this.chkIsActive.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(73, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Category Name";
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(193, 56);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCategory.Properties.Appearance.Options.UseFont = true;
			this.txtCategory.Size = new System.Drawing.Size(285, 28);
			this.txtCategory.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cmdDelete);
			this.panel3.Controls.Add(this.cmdNew);
			this.panel3.Controls.Add(this.cmdSave);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 684);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1024, 45);
			this.panel3.TabIndex = 4;
			// 
			// cmdDelete
			// 
			this.cmdDelete.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdDelete.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.cmdDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDelete.Appearance.Options.UseBackColor = true;
			this.cmdDelete.Appearance.Options.UseBorderColor = true;
			this.cmdDelete.Appearance.Options.UseFont = true;
			this.cmdDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
			this.cmdDelete.Location = new System.Drawing.Point(903, 5);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(111, 35);
			this.cmdDelete.TabIndex = 6;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			// 
			// cmdNew
			// 
			this.cmdNew.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdNew.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdNew.Appearance.Options.UseBackColor = true;
			this.cmdNew.Appearance.Options.UseFont = true;
			this.cmdNew.buttonID = null;
			this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdNew.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.Image")));
			this.cmdNew.Location = new System.Drawing.Point(669, 5);
			this.cmdNew.Name = "cmdNew";
			this.cmdNew.Size = new System.Drawing.Size(111, 35);
			this.cmdNew.TabIndex = 4;
			this.cmdNew.TabStop = false;
			this.cmdNew.Text = "New";
			this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdSave.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSave.Appearance.Options.UseBackColor = true;
			this.cmdSave.Appearance.Options.UseBorderColor = true;
			this.cmdSave.Appearance.Options.UseFont = true;
			this.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
			this.cmdSave.Location = new System.Drawing.Point(786, 5);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(111, 35);
			this.cmdSave.TabIndex = 5;
			this.cmdSave.TabStop = false;
			this.cmdSave.Text = "Save";
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// frmCategory
			// 
			this.AcceptButton = this.cmdSave;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.CancelButton = this.lblExit;
			this.ClientSize = new System.Drawing.Size(1372, 780);
			this.Controls.Add(this.pnlCategory);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCategory";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Category";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmCategory_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnlCategory.ResumeLayout(false);
			this.pnlCategory.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCategoryView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Panel pnlCategory;
        private DevExpress.XtraGrid.GridControl grdCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCategoryView;
        private DevExpress.XtraGrid.Columns.GridColumn grdColCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
        private DevExpress.XtraEditors.CheckEdit chkIsActive;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtCategory;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private Controls.BaseZuluButtonControl cmdNew;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCreatedOn;
    }
}
