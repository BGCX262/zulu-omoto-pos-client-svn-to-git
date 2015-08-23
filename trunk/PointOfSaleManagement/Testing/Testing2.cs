using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService;
using Zulu.BusinessService.Data;
using ZuluPOSClient.Controls;

namespace ZuluPOSClient.Testing
{
	public partial class Testing2 : Form
	{
		public Testing2()
		{
			InitializeComponent();
		}

		private void Testing2_Load(object sender, EventArgs e)
		{
			var formControls = ZuluContext.Current.FormControls;

			FormControl formControl = formControls.FirstOrDefault();
		}


	}
}
