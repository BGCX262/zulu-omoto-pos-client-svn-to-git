using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Util;
using DevExpress.XtraEditors;

namespace ZuluPOSClient.Controls
{
	public partial class BaseZuluButtonControl : SimpleButton
	{
		public BaseZuluButtonControl()
		{

		}

		public void UserCheck()
		{
			this.Enabled =  this.Name == "button1";
		}

		public string buttonID { get; set; }
	}
}
