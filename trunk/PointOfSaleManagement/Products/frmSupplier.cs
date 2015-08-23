using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZuluPOSClient.Products
{
    public partial class frmSupplier : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
