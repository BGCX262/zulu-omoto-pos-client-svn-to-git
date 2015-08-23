using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Settings;

namespace ZuluPOSClient.Sales
{
    public partial class frmSaleVoucher : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        public frmSaleVoucher()
        {
            InitializeComponent();

            //pnlSaleVoucher.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlSaleVoucher.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlSaleVoucher.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlSaleVoucher.Left = 0;
            }
        }

        private void frmSaleVoucher_Load(object sender, EventArgs e)
        {

        }

        private void cmdNew_Click(object sender, EventArgs e)
        {

        }

        private void NewVoucher() //Function Key F7
        {
            
        }

        private void PendingVoucher() //Fucntion Key F9
        { 
        
        }

        private void PrintVoucher() //Function Key F11
        {

        }

        private void DeleteItem() //Function Key Ctrl + Del
        { 
        
        }

        private void DeleteVoc() //Function Key Shift + Del
        {

        }

        private void frmSaleVoucher_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
                NewVoucher();
            if (e.KeyCode == Keys.F9)
                PendingVoucher();
            if (e.KeyCode == Keys.F11)
                PrintVoucher();
            if (((Control.ModifierKeys & Keys.Shift) == Keys.Control) && (e.KeyCode == Keys.Delete))
                DeleteVoc();
            if (((Control.ModifierKeys & Keys.Control) == Keys.Control) && (e.KeyCode == Keys.Delete))
                DeleteItem();
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmSaleVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {

        }       
    }
}
