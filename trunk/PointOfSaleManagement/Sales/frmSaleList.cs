using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZuluPOSClient.Sales
{
    public partial class frmSaleList : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        public frmSaleList()
        {
            InitializeComponent();
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
