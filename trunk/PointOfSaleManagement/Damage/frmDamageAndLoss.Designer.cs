namespace ZuluPOSClient.Damage
{
    partial class frmDamageAndLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDamageAndLoss));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grdProductView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new ZuluPOSClient.Controls.BaseZuluButtonControl();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.gridColQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1386, 32);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(617, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Damage and Loss";
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
            this.lblExit.Location = new System.Drawing.Point(1344, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 17);
            this.lblExit.TabIndex = 1;
            this.lblExit.TabStop = true;
            this.lblExit.Text = "E&xit";
            this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.memoEdit1);
            this.pnlProduct.Controls.Add(this.label2);
            this.pnlProduct.Controls.Add(this.label8);
            this.pnlProduct.Controls.Add(this.grdProduct);
            this.pnlProduct.Controls.Add(this.panel3);
            this.pnlProduct.Controls.Add(this.textEdit1);
            this.pnlProduct.Location = new System.Drawing.Point(181, 33);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1024, 729);
            this.pnlProduct.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Date";
            // 
            // grdProduct
            // 
            this.grdProduct.Location = new System.Drawing.Point(12, 189);
            this.grdProduct.MainView = this.grdProductView;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive});
            this.grdProduct.Size = new System.Drawing.Size(1001, 482);
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
            this.gridColBarcode,
            this.grdColProductName,
            this.gridColQty});
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
            // gridColBarcode
            // 
            this.gridColBarcode.Caption = "Barcode";
            this.gridColBarcode.FieldName = "Name";
            this.gridColBarcode.Name = "gridColBarcode";
            this.gridColBarcode.Visible = true;
            this.gridColBarcode.VisibleIndex = 0;
            this.gridColBarcode.Width = 240;
            // 
            // grdColProductName
            // 
            this.grdColProductName.Caption = "Item Name";
            this.grdColProductName.FieldName = "Published";
            this.grdColProductName.Name = "grdColProductName";
            this.grdColProductName.OptionsColumn.AllowEdit = false;
            this.grdColProductName.Visible = true;
            this.grdColProductName.VisibleIndex = 1;
            this.grdColProductName.Width = 600;
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
            this.cmdDelete.Location = new System.Drawing.Point(888, 5);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(125, 35);
            this.cmdDelete.TabIndex = 9;
            this.cmdDelete.Text = "Item Delete";
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
            this.cmdNew.Location = new System.Drawing.Point(654, 5);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(111, 35);
            this.cmdNew.TabIndex = 7;
            this.cmdNew.TabStop = false;
            this.cmdNew.Text = "    New";
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
            this.cmdSave.Location = new System.Drawing.Point(771, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(111, 35);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.TabStop = false;
            this.cmdSave.Text = "Save";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = null;
            this.textEdit1.Location = new System.Drawing.Point(133, 48);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.Mask.EditMask = "";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textEdit1.Size = new System.Drawing.Size(289, 28);
            this.textEdit1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Remark";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(133, 91);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(603, 78);
            this.memoEdit1.TabIndex = 53;
            // 
            // gridColQty
            // 
            this.gridColQty.Caption = "Qty";
            this.gridColQty.Name = "gridColQty";
            this.gridColQty.Visible = true;
            this.gridColQty.VisibleIndex = 2;
            this.gridColQty.Width = 146;
            // 
            // frmDamageAndLoss
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDamageAndLoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damage / Loss";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Panel pnlProduct;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grdProductView;
        private DevExpress.XtraGrid.Columns.GridColumn grdColProductID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn grdColProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private Controls.BaseZuluButtonControl cmdNew;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.DateEdit textEdit1;
    }
}
