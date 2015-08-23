namespace ZuluPOSClient.Products
{
    partial class frmProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.pnlProduct = new System.Windows.Forms.Panel();
			this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
			this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.grdProduct = new DevExpress.XtraGrid.GridControl();
			this.grdProductView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.grdColProductID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColProductUnit = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.gridColCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
			this.cmdNew = new ZuluPOSClient.Controls.BaseZuluButtonControl();
			this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnlProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdProductView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1380, 32);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Location = new System.Drawing.Point(654, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 26);
			this.label1.TabIndex = 8;
			this.label1.Text = "Product";
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
			this.lblExit.Location = new System.Drawing.Point(1340, 9);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(32, 17);
			this.lblExit.TabIndex = 1;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "E&xit";
			this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// pnlProduct
			// 
			this.pnlProduct.Controls.Add(this.comboBoxEdit1);
			this.pnlProduct.Controls.Add(this.chkIsActive);
			this.pnlProduct.Controls.Add(this.label2);
			this.pnlProduct.Controls.Add(this.label8);
			this.pnlProduct.Controls.Add(this.textEdit1);
			this.pnlProduct.Controls.Add(this.grdProduct);
			this.pnlProduct.Controls.Add(this.panel3);
			this.pnlProduct.Location = new System.Drawing.Point(178, 34);
			this.pnlProduct.Name = "pnlProduct";
			this.pnlProduct.Size = new System.Drawing.Size(1024, 729);
			this.pnlProduct.TabIndex = 1;
			// 
			// comboBoxEdit1
			// 
			this.comboBoxEdit1.Location = new System.Drawing.Point(690, 48);
			this.comboBoxEdit1.Name = "comboBoxEdit1";
			this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
			this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
			this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.comboBoxEdit1.Size = new System.Drawing.Size(207, 28);
			this.comboBoxEdit1.TabIndex = 56;
			// 
			// chkIsActive
			// 
			this.chkIsActive.Location = new System.Drawing.Point(415, 53);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkIsActive.Properties.Appearance.Options.UseFont = true;
			this.chkIsActive.Properties.Caption = "IsActive";
			this.chkIsActive.Size = new System.Drawing.Size(75, 21);
			this.chkIsActive.TabIndex = 55;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(583, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 52;
			this.label2.Text = "Product Unit";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(39, 53);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 17);
			this.label8.TabIndex = 52;
			this.label8.Text = "Product";
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(114, 48);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit1.Properties.Appearance.Options.UseFont = true;
			this.textEdit1.Size = new System.Drawing.Size(289, 28);
			this.textEdit1.TabIndex = 47;
			// 
			// grdProduct
			// 
			this.grdProduct.Location = new System.Drawing.Point(12, 137);
			this.grdProduct.MainView = this.grdProductView;
			this.grdProduct.Name = "grdProduct";
			this.grdProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive});
			this.grdProduct.Size = new System.Drawing.Size(1001, 534);
			this.grdProduct.TabIndex = 6;
			this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdProductView});
			// 
			// grdProductView
			// 
			this.grdProductView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.grdProductView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.grdProductView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdProductView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.grdProductView.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.grdProductView.Appearance.HeaderPanel.Options.UseBorderColor = true;
			this.grdProductView.Appearance.HeaderPanel.Options.UseFont = true;
			this.grdProductView.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.grdProductView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColProductID,
            this.gridColName,
            this.gridColProductUnit,
            this.grdColIsActive,
            this.gridColCreatedOn});
			this.grdProductView.GridControl = this.grdProduct;
			this.grdProductView.Name = "grdProductView";
			this.grdProductView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.grdProductView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.grdProductView.OptionsCustomization.AllowColumnMoving = false;
			this.grdProductView.OptionsCustomization.AllowColumnResizing = false;
			this.grdProductView.OptionsView.EnableAppearanceEvenRow = true;
			this.grdProductView.OptionsView.ShowGroupExpandCollapseButtons = false;
			this.grdProductView.OptionsView.ShowGroupPanel = false;
			this.grdProductView.PaintStyleName = "UltraFlat";
			this.grdProductView.RowHeight = 28;
			this.grdProductView.ViewCaptionHeight = 38;
			// 
			// grdColProductID
			// 
			this.grdColProductID.Caption = "ProductID";
			this.grdColProductID.FieldName = "ProductID";
			this.grdColProductID.Name = "grdColProductID";
			// 
			// gridColName
			// 
			this.gridColName.Caption = "Product";
			this.gridColName.FieldName = "Name";
			this.gridColName.Name = "gridColName";
			this.gridColName.Visible = true;
			this.gridColName.VisibleIndex = 0;
			this.gridColName.Width = 778;
			// 
			// gridColProductUnit
			// 
			this.gridColProductUnit.Caption = "Product Unit";
			this.gridColProductUnit.Name = "gridColProductUnit";
			this.gridColProductUnit.Visible = true;
			this.gridColProductUnit.VisibleIndex = 1;
			this.gridColProductUnit.Width = 150;
			// 
			// grdColIsActive
			// 
			this.grdColIsActive.Caption = "Is Active";
			this.grdColIsActive.ColumnEdit = this.repositoryItemChkIsActive;
			this.grdColIsActive.FieldName = "Published";
			this.grdColIsActive.Name = "grdColIsActive";
			this.grdColIsActive.OptionsColumn.AllowEdit = false;
			this.grdColIsActive.Visible = true;
			this.grdColIsActive.VisibleIndex = 2;
			this.grdColIsActive.Width = 150;
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
			this.cmdDelete.Appearance.ForeColor = System.Drawing.Color.Red;
			this.cmdDelete.Appearance.Options.UseBackColor = true;
			this.cmdDelete.Appearance.Options.UseBorderColor = true;
			this.cmdDelete.Appearance.Options.UseFont = true;
			this.cmdDelete.Appearance.Options.UseForeColor = true;
			this.cmdDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
			this.cmdDelete.Location = new System.Drawing.Point(903, 5);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(111, 35);
			this.cmdDelete.TabIndex = 9;
			this.cmdDelete.Text = "Delete";
			// 
			// cmdNew
			// 
			this.cmdNew.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdNew.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.cmdNew.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdNew.Appearance.Options.UseBackColor = true;
			this.cmdNew.Appearance.Options.UseBorderColor = true;
			this.cmdNew.Appearance.Options.UseFont = true;
			this.cmdNew.buttonID = null;
			this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdNew.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.Image")));
			this.cmdNew.Location = new System.Drawing.Point(669, 5);
			this.cmdNew.Name = "cmdNew";
			this.cmdNew.Size = new System.Drawing.Size(111, 35);
			this.cmdNew.TabIndex = 7;
			this.cmdNew.TabStop = false;
			this.cmdNew.Text = "New";
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
			this.cmdSave.TabIndex = 8;
			this.cmdSave.TabStop = false;
			this.cmdSave.Text = "Save";
			// 
			// frmProduct
			// 
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(1380, 788);
			this.Controls.Add(this.pnlProduct);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmProdcut_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnlProduct.ResumeLayout(false);
			this.pnlProduct.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdProductView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Panel pnlProduct;
        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grdProductView;
        private DevExpress.XtraGrid.Columns.GridColumn grdColProductID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCreatedOn;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private Controls.BaseZuluButtonControl cmdNew;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColName;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.CheckEdit chkIsActive;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProductUnit;
    }
}
