namespace ZuluPOSClient.Users
{
    partial class frmUserRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRoles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserRole = new DevExpress.XtraEditors.TextEdit();
            this.grdUserRole = new DevExpress.XtraGrid.GridControl();
            this.userRoleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grdUserRoleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColRoleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColUserRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new ZuluPOSClient.Controls.BaseZuluButtonControl();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.userRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserRoleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(642, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Roles";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.chkIsActive);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUserRole);
            this.panel2.Controls.Add(this.grdUserRole);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(178, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 729);
            this.panel2.TabIndex = 1;
            // 
            // chkIsActive
            // 
            this.chkIsActive.Location = new System.Drawing.Point(168, 96);
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
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "User Role";
            // 
            // txtUserRole
            // 
            this.txtUserRole.Location = new System.Drawing.Point(170, 56);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRole.Properties.Appearance.Options.UseFont = true;
            this.txtUserRole.Size = new System.Drawing.Size(250, 28);
            this.txtUserRole.TabIndex = 1;
            // 
            // grdUserRole
            // 
            this.grdUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUserRole.DataSource = this.userRoleBindingSource1;
            this.grdUserRole.Location = new System.Drawing.Point(11, 147);
            this.grdUserRole.MainView = this.grdUserRoleView;
            this.grdUserRole.Name = "grdUserRole";
            this.grdUserRole.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive});
            this.grdUserRole.Size = new System.Drawing.Size(1003, 523);
            this.grdUserRole.TabIndex = 3;
            this.grdUserRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdUserRoleView});
            // 
            // userRoleBindingSource1
            // 
            this.userRoleBindingSource1.DataSource = typeof(Zulu.BusinessService.Data.UserRole);
            // 
            // grdUserRoleView
            // 
            this.grdUserRoleView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.grdUserRoleView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.grdUserRoleView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUserRoleView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Silver;
            this.grdUserRoleView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdUserRoleView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdUserRoleView.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdUserRoleView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdUserRoleView.Appearance.VertLine.BorderColor = System.Drawing.Color.Silver;
            this.grdUserRoleView.Appearance.VertLine.Options.UseBorderColor = true;
            this.grdUserRoleView.BestFitMaxRowCount = 6;
            this.grdUserRoleView.ColumnPanelRowHeight = 35;
            this.grdUserRoleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColRoleID,
            this.gridColUserRole,
            this.gridColIsActive});
            this.grdUserRoleView.FixedLineWidth = 1;
            this.grdUserRoleView.GridControl = this.grdUserRole;
            this.grdUserRoleView.Name = "grdUserRoleView";
            this.grdUserRoleView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdUserRoleView.OptionsBehavior.AutoPopulateColumns = false;
            this.grdUserRoleView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.grdUserRoleView.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.grdUserRoleView.OptionsBehavior.Editable = false;
            this.grdUserRoleView.OptionsCustomization.AllowColumnMoving = false;
            this.grdUserRoleView.OptionsCustomization.AllowColumnResizing = false;
            this.grdUserRoleView.OptionsCustomization.AllowGroup = false;
            this.grdUserRoleView.OptionsCustomization.AllowQuickHideColumns = false;
            this.grdUserRoleView.OptionsMenu.EnableColumnMenu = false;
            this.grdUserRoleView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdUserRoleView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdUserRoleView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdUserRoleView.OptionsView.ShowGroupPanel = false;
            this.grdUserRoleView.PaintStyleName = "UltraFlat";
            this.grdUserRoleView.RowHeight = 28;
            this.grdUserRoleView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grdUserRoleView_RowCellClick);
            // 
            // gridColRoleID
            // 
            this.gridColRoleID.Caption = "RoleID";
            this.gridColRoleID.FieldName = "UserRoleID";
            this.gridColRoleID.Name = "gridColRoleID";
            // 
            // gridColUserRole
            // 
            this.gridColUserRole.Caption = "User Role";
            this.gridColUserRole.FieldName = "Name";
            this.gridColUserRole.Name = "gridColUserRole";
            this.gridColUserRole.OptionsColumn.AllowMove = false;
            this.gridColUserRole.Visible = true;
            this.gridColUserRole.VisibleIndex = 0;
            this.gridColUserRole.Width = 217;
            // 
            // gridColIsActive
            // 
            this.gridColIsActive.Caption = "Is Active";
            this.gridColIsActive.ColumnEdit = this.repositoryItemChkIsActive;
            this.gridColIsActive.FieldName = "Active";
            this.gridColIsActive.Name = "gridColIsActive";
            this.gridColIsActive.OptionsColumn.AllowEdit = false;
            this.gridColIsActive.OptionsColumn.AllowMove = false;
            this.gridColIsActive.Visible = true;
            this.gridColIsActive.VisibleIndex = 1;
            this.gridColIsActive.Width = 125;
            // 
            // repositoryItemChkIsActive
            // 
            this.repositoryItemChkIsActive.AutoHeight = false;
            this.repositoryItemChkIsActive.Name = "repositoryItemChkIsActive";
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
            this.cmdNew.Text = "  New";
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
            // userRoleBindingSource
            // 
            this.userRoleBindingSource.DataSource = typeof(Zulu.BusinessService.Data.UserRole);
            // 
            // frmUserRoles
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1380, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUserRoles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserRoleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userRoleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private Controls.BaseZuluButtonControl cmdNew;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraGrid.GridControl grdUserRole;
        private DevExpress.XtraGrid.Views.Grid.GridView grdUserRoleView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColRoleID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColUserRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
        private DevExpress.XtraEditors.CheckEdit chkIsActive;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtUserRole;
        private System.Windows.Forms.BindingSource userRoleBindingSource;
		private System.Windows.Forms.BindingSource userRoleBindingSource1;
    }
}
