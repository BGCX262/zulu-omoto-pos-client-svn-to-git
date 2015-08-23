using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZuluPOSClient.Sales
{
    public partial class frmSaleReceived : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        public frmSaleReceived()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
