namespace ZuluPOSClient.Forms
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.grdMain = new DevExpress.XtraGrid.GridControl();
			this.grdView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColCategory = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColProductName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColBalanceQty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlFunction = new System.Windows.Forms.Panel();
			this.baseZuluButtonControl2 = new ZuluPOSClient.Controls.BaseZuluButtonControl();
			this.baseZuluButtonControl1 = new ZuluPOSClient.Controls.BaseZuluButtonControl();
			this.cmdUsers = new ZuluPOSClient.Controls.BaseZuluButtonControl();
			this.cmdUserRoles = new ZuluPOSClient.Controls.BaseZuluButtonControl();
			this.cmdMembers = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lineShapeMain = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblBrandID = new System.Windows.Forms.Label();
			this.lblTwpNCity = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblUserLevel = new System.Windows.Forms.Label();
			this.lblCurrentUserName = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.picUser = new System.Windows.Forms.PictureBox();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.timerClock = new System.Windows.Forms.Timer(this.components);
			this.pnlMain.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
			this.pnlFunction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.pnlMain.Controls.Add(this.panel2);
			this.pnlMain.Controls.Add(this.lblEmail);
			this.pnlMain.Controls.Add(this.lblPhone);
			this.pnlMain.Controls.Add(this.lblBrandID);
			this.pnlMain.Controls.Add(this.lblTwpNCity);
			this.pnlMain.Controls.Add(this.lblAddress);
			this.pnlMain.Controls.Add(this.lblDate);
			this.pnlMain.Controls.Add(this.lblUserLevel);
			this.pnlMain.Controls.Add(this.lblCurrentUserName);
			this.pnlMain.Controls.Add(this.lblTime);
			this.pnlMain.Controls.Add(this.picUser);
			this.pnlMain.Location = new System.Drawing.Point(6, 32);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(1024, 729);
			this.pnlMain.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.grdMain);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pnlFunction);
			this.panel2.Controls.Add(this.shapeContainer2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 195);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1024, 534);
			this.panel2.TabIndex = 11;
			// 
			// grdMain
			// 
			this.grdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.grdMain.Location = new System.Drawing.Point(14, 196);
			this.grdMain.MainView = this.grdView;
			this.grdMain.Name = "grdMain";
			this.grdMain.Size = new System.Drawing.Size(740, 319);
			this.grdMain.TabIndex = 20;
			this.grdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView});
			// 
			// grdView
			// 
			this.grdView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.grdView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
			this.grdView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Silver;
			this.grdView.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.grdView.Appearance.HeaderPanel.Options.UseBorderColor = true;
			this.grdView.Appearance.HeaderPanel.Options.UseFont = true;
			this.grdView.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.grdView.Appearance.VertLine.BorderColor = System.Drawing.Color.Silver;
			this.grdView.Appearance.VertLine.Options.UseBorderColor = true;
			this.grdView.BestFitMaxRowCount = 6;
			this.grdView.ColumnPanelRowHeight = 35;
			this.grdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColBarcode,
            this.gridColCategory,
            this.gridColProductName,
            this.gridColBalanceQty});
			this.grdView.FixedLineWidth = 1;
			this.grdView.GridControl = this.grdMain;
			this.grdView.Name = "grdView";
			this.grdView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.grdView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.grdView.OptionsBehavior.AutoPopulateColumns = false;
			this.grdView.OptionsBehavior.AutoSelectAllInEditor = false;
			this.grdView.OptionsBehavior.AutoUpdateTotalSummary = false;
			this.grdView.OptionsBehavior.Editable = false;
			this.grdView.OptionsCustomization.AllowColumnMoving = false;
			this.grdView.OptionsCustomization.AllowColumnResizing = false;
			this.grdView.OptionsCustomization.AllowGroup = false;
			this.grdView.OptionsCustomization.AllowQuickHideColumns = false;
			this.grdView.OptionsMenu.EnableColumnMenu = false;
			this.grdView.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.grdView.OptionsView.EnableAppearanceEvenRow = true;
			this.grdView.OptionsView.ShowGroupPanel = false;
			this.grdView.PaintStyleName = "UltraFlat";
			this.grdView.RowHeight = 28;
			// 
			// gridColBarcode
			// 
			this.gridColBarcode.Caption = "Barcode";
			this.gridColBarcode.Name = "gridColBarcode";
			this.gridColBarcode.OptionsColumn.AllowEdit = false;
			this.gridColBarcode.OptionsColumn.AllowFocus = false;
			this.gridColBarcode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.gridColBarcode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColBarcode.OptionsColumn.AllowMove = false;
			this.gridColBarcode.OptionsColumn.AllowShowHide = false;
			this.gridColBarcode.OptionsColumn.AllowSize = false;
			this.gridColBarcode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
			this.gridColBarcode.OptionsColumn.ReadOnly = true;
			this.gridColBarcode.OptionsColumn.ShowInCustomizationForm = false;
			this.gridColBarcode.OptionsColumn.ShowInExpressionEditor = false;
			this.gridColBarcode.OptionsColumn.TabStop = false;
			this.gridColBarcode.OptionsFilter.AllowAutoFilter = false;
			this.gridColBarcode.OptionsFilter.AllowFilter = false;
			this.gridColBarcode.Visible = true;
			this.gridColBarcode.VisibleIndex = 0;
			this.gridColBarcode.Width = 100;
			// 
			// gridColCategory
			// 
			this.gridColCategory.Caption = "Category";
			this.gridColCategory.Name = "gridColCategory";
			this.gridColCategory.OptionsColumn.AllowEdit = false;
			this.gridColCategory.OptionsColumn.AllowFocus = false;
			this.gridColCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.gridColCategory.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColCategory.OptionsColumn.AllowMove = false;
			this.gridColCategory.OptionsColumn.AllowShowHide = false;
			this.gridColCategory.OptionsColumn.AllowSize = false;
			this.gridColCategory.OptionsColumn.ShowInCustomizationForm = false;
			this.gridColCategory.OptionsColumn.ShowInExpressionEditor = false;
			this.gridColCategory.OptionsFilter.AllowAutoFilter = false;
			this.gridColCategory.OptionsFilter.AllowFilter = false;
			this.gridColCategory.Visible = true;
			this.gridColCategory.VisibleIndex = 1;
			this.gridColCategory.Width = 158;
			// 
			// gridColProductName
			// 
			this.gridColProductName.Caption = "Product Name";
			this.gridColProductName.Name = "gridColProductName";
			this.gridColProductName.OptionsColumn.AllowEdit = false;
			this.gridColProductName.OptionsColumn.AllowFocus = false;
			this.gridColProductName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.gridColProductName.OptionsColumn.AllowIncrementalSearch = false;
			this.gridColProductName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColProductName.OptionsColumn.AllowMove = false;
			this.gridColProductName.OptionsColumn.AllowShowHide = false;
			this.gridColProductName.OptionsColumn.AllowSize = false;
			this.gridColProductName.OptionsFilter.AllowAutoFilter = false;
			this.gridColProductName.OptionsFilter.AllowFilter = false;
			this.gridColProductName.Visible = true;
			this.gridColProductName.VisibleIndex = 2;
			this.gridColProductName.Width = 432;
			// 
			// gridColBalanceQty
			// 
			this.gridColBalanceQty.Caption = "Balance Qty";
			this.gridColBalanceQty.Name = "gridColBalanceQty";
			this.gridColBalanceQty.Visible = true;
			this.gridColBalanceQty.VisibleIndex = 3;
			this.gridColBalanceQty.Width = 120;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label13.Location = new System.Drawing.Point(12, 149);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(350, 25);
			this.label13.TabIndex = 19;
			this.label13.Text = "Head Office သုိ႔ ယေန႔ မွာရမည့္ ပစၥည္းမ်ား စာရင္း";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label11.Location = new System.Drawing.Point(211, 111);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(167, 25);
			this.label11.TabIndex = 18;
			this.label11.Text = "00";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label12.Location = new System.Drawing.Point(18, 111);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(198, 25);
			this.label12.TabIndex = 17;
			this.label12.Text = "ယေန႔အတြက္ ပ်မ္းမွ်ေရာင္းရေငြ";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label9.Location = new System.Drawing.Point(584, 84);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(167, 25);
			this.label9.TabIndex = 16;
			this.label9.Text = "00";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label10.Location = new System.Drawing.Point(579, 55);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(172, 25);
			this.label10.TabIndex = 15;
			this.label10.Text = "00";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label7.Location = new System.Drawing.Point(420, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 25);
			this.label7.TabIndex = 14;
			this.label7.Text = "Return အတြက္ ေငြ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label8.Location = new System.Drawing.Point(420, 55);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(177, 25);
			this.label8.TabIndex = 13;
			this.label8.Text = "Damage/Loss အတြက္ ေငြ";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label5.Location = new System.Drawing.Point(211, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 25);
			this.label5.TabIndex = 12;
			this.label5.Text = "00";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label6.Location = new System.Drawing.Point(206, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(172, 25);
			this.label6.TabIndex = 11;
			this.label6.Text = "00";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label4.Location = new System.Drawing.Point(18, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "ယခု User ၏ စုစုေပါင္း ေရာင္းရေငြ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label3.Location = new System.Drawing.Point(17, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "ယေန႔ စုစုေပါင္း ေရာင္းရေငြ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.label2.Location = new System.Drawing.Point(12, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(263, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "ယေန႔ ဆုိင္၏ အ၀င္အထြက္ စာရင္းမ်ား";
			// 
			// pnlFunction
			// 
			this.pnlFunction.Controls.Add(this.baseZuluButtonControl2);
			this.pnlFunction.Controls.Add(this.baseZuluButtonControl1);
			this.pnlFunction.Controls.Add(this.cmdUsers);
			this.pnlFunction.Controls.Add(this.cmdUserRoles);
			this.pnlFunction.Controls.Add(this.cmdMembers);
			this.pnlFunction.Controls.Add(this.simpleButton1);
			this.pnlFunction.Controls.Add(this.textEdit1);
			this.pnlFunction.Controls.Add(this.dateEdit1);
			this.pnlFunction.Controls.Add(this.label15);
			this.pnlFunction.Controls.Add(this.label14);
			this.pnlFunction.Controls.Add(this.shapeContainer3);
			this.pnlFunction.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlFunction.Location = new System.Drawing.Point(764, 0);
			this.pnlFunction.Name = "pnlFunction";
			this.pnlFunction.Size = new System.Drawing.Size(260, 534);
			this.pnlFunction.TabIndex = 0;
			// 
			// baseZuluButtonControl2
			// 
			this.baseZuluButtonControl2.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.baseZuluButtonControl2.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.baseZuluButtonControl2.Appearance.Options.UseBackColor = true;
			this.baseZuluButtonControl2.Appearance.Options.UseFont = true;
			this.baseZuluButtonControl2.buttonID = null;
			this.baseZuluButtonControl2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.baseZuluButtonControl2.Image = ((System.Drawing.Image)(resources.GetObject("baseZuluButtonControl2.Image")));
			this.baseZuluButtonControl2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
			this.baseZuluButtonControl2.Location = new System.Drawing.Point(13, 335);
			this.baseZuluButtonControl2.Name = "baseZuluButtonControl2";
			this.baseZuluButtonControl2.Size = new System.Drawing.Size(111, 61);
			this.baseZuluButtonControl2.TabIndex = 9;
			this.baseZuluButtonControl2.Text = "Sales";
			this.baseZuluButtonControl2.Click += new System.EventHandler(this.cmdUsers_Click_1);
			// 
			// baseZuluButtonControl1
			// 
			this.baseZuluButtonControl1.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.baseZuluButtonControl1.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.baseZuluButtonControl1.Appearance.Options.UseBackColor = true;
			this.baseZuluButtonControl1.Appearance.Options.UseFont = true;
			this.baseZuluButtonControl1.buttonID = null;
			this.baseZuluButtonControl1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.baseZuluButtonControl1.Image = ((System.Drawing.Image)(resources.GetObject("baseZuluButtonControl1.Image")));
			this.baseZuluButtonControl1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
			this.baseZuluButtonControl1.Location = new System.Drawing.Point(135, 268);
			this.baseZuluButtonControl1.Name = "baseZuluButtonControl1";
			this.baseZuluButtonControl1.Size = new System.Drawing.Size(111, 61);
			this.baseZuluButtonControl1.TabIndex = 9;
			this.baseZuluButtonControl1.Text = "Damage/Loss";
			this.baseZuluButtonControl1.Click += new System.EventHandler(this.cmdUsers_Click_1);
			// 
			// cmdUsers
			// 
			this.cmdUsers.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdUsers.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdUsers.Appearance.Options.UseBackColor = true;
			this.cmdUsers.Appearance.Options.UseFont = true;
			this.cmdUsers.buttonID = null;
			this.cmdUsers.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdUsers.Image = ((System.Drawing.Image)(resources.GetObject("cmdUsers.Image")));
			this.cmdUsers.Location = new System.Drawing.Point(135, 199);
			this.cmdUsers.Name = "cmdUsers";
			this.cmdUsers.Size = new System.Drawing.Size(111, 61);
			this.cmdUsers.TabIndex = 9;
			this.cmdUsers.Text = "Users";
			this.cmdUsers.Click += new System.EventHandler(this.cmdUsers_Click_1);
			// 
			// cmdUserRoles
			// 
			this.cmdUserRoles.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdUserRoles.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdUserRoles.Appearance.Options.UseBackColor = true;
			this.cmdUserRoles.Appearance.Options.UseFont = true;
			this.cmdUserRoles.buttonID = null;
			this.cmdUserRoles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdUserRoles.Image = ((System.Drawing.Image)(resources.GetObject("cmdUserRoles.Image")));
			this.cmdUserRoles.Location = new System.Drawing.Point(13, 199);
			this.cmdUserRoles.Name = "cmdUserRoles";
			this.cmdUserRoles.Size = new System.Drawing.Size(111, 61);
			this.cmdUserRoles.TabIndex = 8;
			this.cmdUserRoles.Text = "User Roles";
			this.cmdUserRoles.Click += new System.EventHandler(this.cmdUserRoles_Click);
			// 
			// cmdMembers
			// 
			this.cmdMembers.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdMembers.Appearance.BorderColor = System.Drawing.Color.LightBlue;
			this.cmdMembers.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdMembers.Appearance.Options.UseBackColor = true;
			this.cmdMembers.Appearance.Options.UseBorderColor = true;
			this.cmdMembers.Appearance.Options.UseFont = true;
			this.cmdMembers.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdMembers.Image = ((System.Drawing.Image)(resources.GetObject("cmdMembers.Image")));
			this.cmdMembers.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
			this.cmdMembers.Location = new System.Drawing.Point(13, 268);
			this.cmdMembers.Name = "cmdMembers";
			this.cmdMembers.Size = new System.Drawing.Size(111, 61);
			this.cmdMembers.TabIndex = 7;
			this.cmdMembers.Text = "Members";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.LightBlue;
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.Options.UseBackColor = true;
			this.simpleButton1.Appearance.Options.UseBorderColor = true;
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
			this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.simpleButton1.Location = new System.Drawing.Point(204, 98);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(35, 24);
			this.simpleButton1.TabIndex = 6;
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(20, 98);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit1.Properties.Appearance.Options.UseFont = true;
			this.textEdit1.Size = new System.Drawing.Size(180, 24);
			this.textEdit1.TabIndex = 5;
			// 
			// dateEdit1
			// 
			this.dateEdit1.EditValue = null;
			this.dateEdit1.Location = new System.Drawing.Point(20, 61);
			this.dateEdit1.Name = "dateEdit1";
			this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateEdit1.Properties.Appearance.Options.UseFont = true;
			this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dateEdit1.Size = new System.Drawing.Size(222, 20);
			this.dateEdit1.TabIndex = 4;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.label15.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.label15.Location = new System.Drawing.Point(8, 147);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(118, 25);
			this.label15.TabIndex = 3;
			this.label15.Text = "POS Functions";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.label14.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.label14.Location = new System.Drawing.Point(10, 9);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(128, 25);
			this.label14.TabIndex = 1;
			this.label14.Text = "Voucher Search";
			// 
			// shapeContainer3
			// 
			this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer3.Name = "shapeContainer3";
			this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1,
            this.lineShape5});
			this.shapeContainer3.Size = new System.Drawing.Size(260, 534);
			this.shapeContainer3.TabIndex = 0;
			this.shapeContainer3.TabStop = false;
			// 
			// rectangleShape2
			// 
			this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.rectangleShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.rectangleShape2.FillGradientColor = System.Drawing.Color.LightGoldenrodYellow;
			this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.rectangleShape2.Location = new System.Drawing.Point(2, 139);
			this.rectangleShape2.Name = "rectangleShape2";
			this.rectangleShape2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.rectangleShape2.Size = new System.Drawing.Size(256, 38);
			// 
			// rectangleShape1
			// 
			this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.rectangleShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.rectangleShape1.FillGradientColor = System.Drawing.Color.LightGoldenrodYellow;
			this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.rectangleShape1.Location = new System.Drawing.Point(2, 1);
			this.rectangleShape1.Name = "rectangleShape1";
			this.rectangleShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.rectangleShape1.Size = new System.Drawing.Size(256, 38);
			// 
			// lineShape5
			// 
			this.lineShape5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.lineShape5.Name = "lineShape5";
			this.lineShape5.X1 = 1;
			this.lineShape5.X2 = 1;
			this.lineShape5.Y1 = 2;
			this.lineShape5.Y2 = 537;
			// 
			// shapeContainer2
			// 
			this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer2.Name = "shapeContainer2";
			this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShapeMain,
            this.lineShape1,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2});
			this.shapeContainer2.Size = new System.Drawing.Size(1024, 534);
			this.shapeContainer2.TabIndex = 3;
			this.shapeContainer2.TabStop = false;
			// 
			// lineShapeMain
			// 
			this.lineShapeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lineShapeMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lineShapeMain.BorderWidth = 2;
			this.lineShapeMain.Name = "lineShapeMain";
			this.lineShapeMain.X1 = -1;
			this.lineShapeMain.X2 = 1023;
			this.lineShapeMain.Y1 = 1;
			this.lineShapeMain.Y2 = 1;
			// 
			// lineShape1
			// 
			this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lineShape1.BorderColor = System.Drawing.Color.LimeGreen;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 0;
			this.lineShape1.X2 = 1024;
			this.lineShape1.Y1 = 2;
			this.lineShape1.Y2 = 2;
			// 
			// lineShape4
			// 
			this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lineShape4.Name = "lineShape4";
			this.lineShape4.X1 = 14;
			this.lineShape4.X2 = 778;
			this.lineShape4.Y1 = 177;
			this.lineShape4.Y2 = 177;
			// 
			// lineShape3
			// 
			this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lineShape3.Name = "lineShape3";
			this.lineShape3.X1 = 407;
			this.lineShape3.X2 = 407;
			this.lineShape3.Y1 = 54;
			this.lineShape3.Y2 = 132;
			// 
			// lineShape2
			// 
			this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 14;
			this.lineShape2.X2 = 778;
			this.lineShape2.Y1 = 39;
			this.lineShape2.Y2 = 39;
			// 
			// lblEmail
			// 
			this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblEmail.Location = new System.Drawing.Point(454, 165);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(549, 25);
			this.lblEmail.TabIndex = 10;
			this.lblEmail.Text = "E-mail : ymn@mail.com";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPhone
			// 
			this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblPhone.Location = new System.Drawing.Point(493, 140);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(510, 25);
			this.lblPhone.TabIndex = 9;
			this.lblPhone.Text = "PH : 01-229900";
			this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBrandID
			// 
			this.lblBrandID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBrandID.Font = new System.Drawing.Font("Zawgyi-One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBrandID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblBrandID.Location = new System.Drawing.Point(665, 35);
			this.lblBrandID.Name = "lblBrandID";
			this.lblBrandID.Size = new System.Drawing.Size(338, 40);
			this.lblBrandID.TabIndex = 8;
			this.lblBrandID.Text = "Branch ID";
			this.lblBrandID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTwpNCity
			// 
			this.lblTwpNCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTwpNCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblTwpNCity.Location = new System.Drawing.Point(509, 115);
			this.lblTwpNCity.Name = "lblTwpNCity";
			this.lblTwpNCity.Size = new System.Drawing.Size(494, 25);
			this.lblTwpNCity.TabIndex = 7;
			this.lblTwpNCity.Text = "Lanmadaw Township, Yangon";
			this.lblTwpNCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblAddress
			// 
			this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblAddress.Location = new System.Drawing.Point(504, 90);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(499, 25);
			this.lblAddress.TabIndex = 6;
			this.lblAddress.Text = "No. 77, Wardan Street, Middle Block";
			this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDate
			// 
			this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblDate.Location = new System.Drawing.Point(14, 56);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(350, 25);
			this.lblDate.TabIndex = 5;
			this.lblDate.Text = "Monday, 12 March 2013";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblUserLevel
			// 
			this.lblUserLevel.AutoSize = true;
			this.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblUserLevel.Location = new System.Drawing.Point(148, 165);
			this.lblUserLevel.Name = "lblUserLevel";
			this.lblUserLevel.Size = new System.Drawing.Size(80, 25);
			this.lblUserLevel.TabIndex = 4;
			this.lblUserLevel.Text = "User Level";
			// 
			// lblCurrentUserName
			// 
			this.lblCurrentUserName.AutoSize = true;
			this.lblCurrentUserName.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblCurrentUserName.Location = new System.Drawing.Point(148, 138);
			this.lblCurrentUserName.Name = "lblCurrentUserName";
			this.lblCurrentUserName.Size = new System.Drawing.Size(165, 26);
			this.lblCurrentUserName.TabIndex = 3;
			this.lblCurrentUserName.Text = "Current User Name";
			// 
			// lblTime
			// 
			this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTime.Font = new System.Drawing.Font("Myriad Web Pro", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
			this.lblTime.Location = new System.Drawing.Point(3, 3);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(374, 62);
			this.lblTime.TabIndex = 2;
			this.lblTime.Text = "10 : 10 : 11 PM";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// picUser
			// 
			this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
			this.picUser.Location = new System.Drawing.Point(26, 84);
			this.picUser.Name = "picUser";
			this.picUser.Size = new System.Drawing.Size(105, 105);
			this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picUser.TabIndex = 1;
			this.picUser.TabStop = false;
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
			this.lblExit.Location = new System.Drawing.Point(996, 9);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(32, 17);
			this.lblExit.TabIndex = 1;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "E&xit";
			this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.lblExit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1036, 32);
			this.panel1.TabIndex = 2;
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
			// timerClock
			// 
			this.timerClock.Enabled = true;
			this.timerClock.Interval = 1000;
			this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
			// 
			// frmMain
			// 
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(1036, 750);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlMain);
			this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "POS System :: Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
			this.pnlFunction.ResumeLayout(false);
			this.pnlFunction.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapeMain;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.Label lblCurrentUserName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBrandID;
        private System.Windows.Forms.Label lblTwpNCity;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private DevExpress.XtraGrid.GridControl grdMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColBalanceQty;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton cmdMembers;
        private System.Windows.Forms.Timer timerClock;
        private Controls.BaseZuluButtonControl cmdUserRoles;
        private Controls.BaseZuluButtonControl cmdUsers;
        private Controls.BaseZuluButtonControl baseZuluButtonControl2;
        private Controls.BaseZuluButtonControl baseZuluButtonControl1;
        //3 place
    }
}
