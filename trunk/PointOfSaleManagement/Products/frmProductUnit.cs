using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService;
using Zulu.BusinessService.Data;
using ZuluPOSClient.Forms;

namespace ZuluPOSClient.Products
{
    public partial class frmProductUnit : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        string ProductUnitID;

        public frmProductUnit()
        {
            InitializeComponent();

            pnlProductUnit.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlProductUnit.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlProductUnit.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlProductUnit.Left = 0;
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmProductUnit_Load(object sender, EventArgs e)
        {
            grdProductUnit.DataSource = ProductService.GetAllProductUnit();

            if (grdProductUnitView.DataRowCount > 0)
            {
                grdProductUnitView.MoveFirst();

                var firstRow = grdProductUnitView.GetRow(grdProductUnitView.FocusedRowHandle) as ProductUnit;

                ProductUnitID = firstRow.ProductUnitID.ToString();
                txtProductUnit.Text = firstRow.Name.ToString();
                mmeDescription.Text = firstRow.Description.ToString();
                chkIsActive.EditValue = bool.Parse(firstRow.IsActive.ToString());
            }
        }

        private void grdProductUnitView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (grdProductUnitView.DataRowCount > 0)
            {
                var puRow = grdProductUnitView.GetRow(grdProductUnitView.FocusedRowHandle) as ProductUnit;

                ProductUnitID = puRow.ProductUnitID.ToString();
                txtProductUnit.Text = puRow.Name.ToString();
                mmeDescription.Text = puRow.Description.ToString();
                chkIsActive.EditValue = bool.Parse(puRow.IsActive.ToString());
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            ProductUnitID = string.Empty;
            txtProductUnit.Text = string.Empty;
            mmeDescription.Text = string.Empty;
            chkIsActive.Checked = true;

            txtProductUnit.Focus();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtProductUnit.Text.Length > 0)
            {
                ProductUnit productunit = new ProductUnit();

                if (ProductUnitID.Length > 0)
                {
                    productunit.ProductUnitID = int.Parse(ProductUnitID);
                }
                productunit.Name = txtProductUnit.Text.ToString();
                productunit.Description = mmeDescription.Text.ToString();
                productunit.IsActive = Convert.ToBoolean(chkIsActive.EditValue);

                ProductService.SaveProductUnit(productunit);

                grdProductUnit.DataSource = ProductService.GetAllProductUnit();
            }
            else
            {
                MessageBox.Show("Please, fill the product unit up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductUnit.Focus();
            }
        }
    }
}
