using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using Zulu.BusinessService;
using ZuluPOSClient.Forms;

namespace ZuluPOSClient.Products
{
    public partial class frmProduct : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        public frmProduct()
        {
            InitializeComponent();

            pnlProduct.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlProduct.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlProduct.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlProduct.Left = 0;
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmProdcut_Load(object sender, EventArgs e)
        {
            
        }

    }
}
