using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using Zulu.BusinessService;
using ZuluPOSClient.Controls;
using Zulu.BusinessService.Logs;

namespace ZuluPOSClient.Forms
{
    public partial class frmMain : BaseZuluFormControl
    {
        public frmMain()
        {
            InitializeComponent();
            //pnlMain.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlMain.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlMain.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlMain.Left = 0;
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH : mm : ss tt");
            lblDate.Text = DateTime.Now.ToString("D");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
			frmLogin LoginForm = new frmLogin();

            if (LoginForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.TopMost = false;
                lblCurrentUserName.Text = ZuluContext.Current.CurrentUser.FullName;
            }

        }

        private void cmdUserRoles_Click(object sender, EventArgs e)
        {
            Users.frmUserRoles UserRolesForm = new Users.frmUserRoles();
            UserRolesForm.ShowDialog();
        }

        private void cmdUsers_Click_1(object sender, EventArgs e)
        {
            Users.frmUsers UsersFrom = new Users.frmUsers();
            UsersFrom.ShowDialog();
        }
    }
}
