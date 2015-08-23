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
    public partial class frmCategory : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        string CategoryID;

        public frmCategory()
        {
            InitializeComponent();

            pnlCategory.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlCategory.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlCategory.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlCategory.Left = 0;
            }
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
			grdCategory.DataSource = ProductService.GetAllCategories();

            if (grdCategoryView.DataRowCount > 0)
            {
                grdCategoryView.MoveFirst();

                var firstRow = grdCategoryView.GetRow(grdCategoryView.FocusedRowHandle) as Category;

                CategoryID = firstRow.CategoryID.ToString();
                txtCategory.Text = firstRow.Name.ToString();
                txtCategory.Tag = firstRow.CreatedOn.ToString();
                chkIsActive.EditValue = bool.Parse(firstRow.IsActive.ToString());
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            CategoryID = string.Empty;
            txtCategory.Text = string.Empty;
            txtCategory.Tag = string.Empty;
            chkIsActive.Checked = true;

            txtCategory.Focus();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text.Length > 0)
            {
                Category Category = new Category();

                //for Edit Data
                if (CategoryID.Length > 0)
                {
                    Category.CategoryID = int.Parse(CategoryID);
                    Category.CreatedOn = Convert.ToDateTime(txtCategory.Tag.ToString());
                }
                
                Category.Name = txtCategory.Text.ToString();
                //Category.Deleted = false;
                Category.IsActive = Convert.ToBoolean(chkIsActive.EditValue);                
                Category.UpdatedOn = DateTime.Now;
                
                //for New Data
                if (CategoryID.Length < 0)
                {
                    Category.CreatedOn = DateTime.Now;
                }

                ProductService.SaveCategory(Category);

                grdCategory.DataSource = ProductService.GetAllCategories();
            }
            else
            {
                MessageBox.Show("Please, fill the Category Name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategory.Focus();
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (CategoryID != null)
            {
                ProductService.DeleteCategory(int.Parse(CategoryID));

                grdCategory.DataSource = ProductService.GetAllCategories();
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void grdCategoryView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (grdCategoryView.DataRowCount > 0)
            {
                var urRow = grdCategoryView.GetRow(grdCategoryView.FocusedRowHandle) as Category;

                CategoryID = urRow.CategoryID.ToString();
                txtCategory.Text = urRow.Name.ToString();
                txtCategory.Tag = urRow.CreatedOn.ToString();
                chkIsActive.EditValue = bool.Parse(urRow.IsActive.ToString());
            }
        }
    }
}
