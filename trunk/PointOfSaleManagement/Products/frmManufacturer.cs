using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using ZuluPOSClient.Forms;
using Zulu.BusinessService;

namespace ZuluPOSClient.Products
{
    public partial class frmManufacturer : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        string ManufacturerID;
        public frmManufacturer()
        {
            InitializeComponent();

            pnlManufacturer.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlManufacturer.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlManufacturer.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlManufacturer.Left = 0;
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            ManufacturerID = string.Empty;
            txtManufacture.Text = string.Empty;
            txtManufacture.Tag = string.Empty;
            chkIsActive.Checked = true;

            txtManufacture.Focus();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtManufacture.Text.Length > 0)
            {
                Manufacturer Manufacturer = new Manufacturer();

                //for Edit Data
                if (ManufacturerID.Length > 0 )
                {
                    Manufacturer.ManufacturerID = int.Parse(ManufacturerID);
                    Manufacturer.CreatedOn = Convert.ToDateTime(txtManufacture.Tag.ToString());
                }
                Manufacturer.Name = txtManufacture.Text.ToString();
                Manufacturer.IsActive = Convert.ToBoolean(chkIsActive.EditValue);
                Manufacturer.UpdatedOn = DateTime.Now;

                //for New Data
                if (ManufacturerID.Length < 0)
                {
                    Manufacturer.CreatedOn = DateTime.Now;
                }
                
                ProductService.SaveManufacturer(Manufacturer);

				grdManufacture.DataSource = ProductService.GetAllManufacturer(false);
            }
            else
            {
                MessageBox.Show("Please, fill the product name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManufacture.Focus();
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (ManufacturerID.Length > 0)
            {
                ProductService.DeleteManufacturer(int.Parse(ManufacturerID));

				grdManufacture.DataSource = ProductService.GetAllManufacturer(false);
            }
        }

        private void grdManufactureView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (grdManufactureView.DataRowCount > 0)
            {
				var urRow = grdManufactureView.GetRow(grdManufactureView.FocusedRowHandle) as Manufacturer;

                ManufacturerID = urRow.ManufacturerID.ToString();
                txtManufacture.Text = urRow.Name.ToString();
                txtManufacture.Tag = urRow.CreatedOn.ToString();
                chkIsActive.EditValue = bool.Parse(urRow.IsActive.ToString());
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmManufacture_Load(object sender, EventArgs e)
        {
			grdManufacture.DataSource = ProductService.GetAllManufacturer(false);

            if (grdManufactureView.DataRowCount > 0)
            {
                grdManufactureView.MoveFirst();

                var firstRow = grdManufactureView.GetRow(grdManufactureView.FocusedRowHandle) as Manufacturer;

                ManufacturerID = firstRow.ManufacturerID.ToString();
                txtManufacture.Text = firstRow.Name.ToString();
                txtManufacture.Tag = firstRow.CreatedOn.ToString();
                chkIsActive.EditValue = bool.Parse(firstRow.IsActive.ToString());
            }
        }
    }
}
