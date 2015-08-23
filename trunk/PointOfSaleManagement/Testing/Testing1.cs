using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using ZuluPOSClient.Controls;
using Zulu.BusinessService;
using Zulu.BusinessService.Logs;
using Zulu.BusinessService.Settings;
using Zulu.BusinessService.Util;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;
using Zulu.SyncService.Products;


namespace ZuluPOSClient.Testing
{
	public partial class Testing1 : BaseZuluFormControl
	{
		public Testing1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "XML files (*.xml)|*.xml";
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				SyncProductService.GetSyncProductFromFile(openFileDialog.FileName);
			}

			// deserialize the file into a product, using Specific Encryption settings.

			//FormControl formControl = new FormControl();

			//formControl.Name = textBox1.Text;
			//formControl.DisplayName = textBox2.Text;

			//UserControlService.SaveFormControl(formControl);

			//MessageBox.Show(formControl.FormID.ToString());

			//List<FormControl> formControls = new List<FormControl>();

			//User user = new User();
			////Add all the properties

			//UserService.SaveUser(user);


			//user.RestrictedForms = "1,2,3";
			//user = UserService.GetUserByID(1);

			//formControls.Add(formControl);

			//ZuluContext.Current.FormControls = formControls;

			//Testing2 testForm2 = new Testing2();
			//testForm2.Show();
			//this.Close();
		}

		private void baseZuluButtonControl1_Click(object sender, EventArgs e)
		{

		}

		private void Testing1_Load(object sender, EventArgs e)
		{
			DESCryptoServiceProvider key = new DESCryptoServiceProvider();
		}
	}
}
