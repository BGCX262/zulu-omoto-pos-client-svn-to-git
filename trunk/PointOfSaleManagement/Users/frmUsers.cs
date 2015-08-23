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

namespace ZuluPOSClient.Users
{
    public partial class frmUsers : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        public frmUsers()
        {
            InitializeComponent();
            pnlUsers.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlUsers.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlUsers.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlUsers.Left = 0;
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            
         }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            User users = new User();
            users.Username = txtUserID.Text;
            users.FullName = txtFullName.Text;
            users.Password = "Admin";
            users.Active = Convert.ToBoolean(IsActive.EditValue);
            users.Deleted = false;
			
			UserService.SaveUser(users);

            MessageBox.Show("Complete Save", "Information");
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            var AllUser = UserService.GetAllUsers(true, false);

            grdUsers.DataSource = AllUser;
        }

    }
}
