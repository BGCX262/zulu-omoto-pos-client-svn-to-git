using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZuluPOSClient.Controls;
using Zulu.BusinessService.Data;
using Zulu.BusinessService;

namespace ZuluPOSClient.Users
{
    public partial class frmUserRoles : ZuluPOSClient.Controls.BaseZuluFormControl
    {
        string UserRoleID;
        
        public frmUserRoles()
        {
            InitializeComponent();
        }

        private UserRole GetInfo()
        {
            try
            {

				UserRole userRole = new UserRole();
				var userRoletest = grdUserRoleView.GetDataRow(grdUserRoleView.FocusedRowHandle);

				return userRole;
				//string CurUserID = grdUserRole.h
                
				//if (dsUser.Tables[0].Rows.Count > 0)
				//{
				//    EnableDisable(true);
				//    txtUserRole.Tag = dsUser.Tables[0].Rows[0]["LogInID"].ToString();
				//    txtUserRole.Text = dsUser.Tables[0].Rows[0]["LogInName"].ToString();
				//    chkIsActive.Checked = (bool)dsUser.Tables[0].Rows[0]["LogInIsActive"];
				//}
            }
            catch (Exception)
            {
				return null;
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmUserRoles_Load(object sender, EventArgs e)
        {
            grdUserRole.DataSource = UserService.GetAllUserRoles(false);
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            txtUserRole.Text = string.Empty;
            chkIsActive.Checked = true;

            txtUserRole.Focus();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtUserRole.Text.Length > 0)
            {
                UserRole UserRole = new UserRole();

                if (UserRoleID != null)
                {
                    UserRole.UserRoleID = int.Parse(UserRoleID);
                }
                UserRole.Name = txtUserRole.Text.ToString();
                UserRole.IsActive = Convert.ToBoolean(chkIsActive.EditValue);
                UserRole.CreatedOn = DateTime.Now;
                UserRole.UpdatedOn = DateTime.Now;

                UserService.SaveUserRole(UserRole);

                grdUserRole.DataSource = UserService.GetAllUserRoles(false);
            }
            else
            {
                MessageBox.Show("Please, fill the member id up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserRole.Focus();
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (UserRoleID != null)
            {
                UserRole UserRole = new UserRole();
                
                UserRole.UserRoleID = int.Parse(UserRoleID);
               // UserRole.Deleted = true;

                UserService.SaveUserRole(UserRole);

                grdUserRole.DataSource = UserService.GetAllUserRoles(false);
            }
        }

        private void grdUserRoleView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (grdUserRoleView.DataRowCount > 0)
            {
				DataRow urRows = grdUserRoleView.GetDataRow(grdUserRoleView.FocusedRowHandle);

				var test = grdUserRoleView.GetRow(grdUserRoleView.FocusedRowHandle) as UserRole;

				string userRoleName = test.Name;

				//UserRoleID = urRows.ItemArray[0].ToString();
				//txtUserRole.Text = urRows.ItemArray[1].ToString();
				//chkIsActive.EditValue = bool.Parse(urRows.ItemArray[2].ToString());


            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var userRole = GetInfo();
		}   
    }
}
