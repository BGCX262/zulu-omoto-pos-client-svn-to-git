using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.UserControls;
using Zulu.BusinessService.Sales;
using Zulu.BusinessService.Products;
using Zulu.BusinessService.Settings;
using Zulu.BusinessService.StorageMedia;

namespace ZuluPOSClient.Controls
{
	public partial class BaseZuluUserControl : UserControl
	{
		public IUserControlService UserControlService
		{
			get { return IoC.Resolve<IUserControlService>(); }
		}

		public IUserService UserService
		{
			get { return IoC.Resolve<IUserService>(); }
		}

		public ISaleService SaleService
		{
			get { return IoC.Resolve<ISaleService>(); }
		}

		public IProductService ProductService
		{
			get { return IoC.Resolve<IProductService>(); }
		}

		public ISettingService SettingService
		{
			get { return IoC.Resolve<ISettingService>(); }
		}

		public IMediaService MediaService
		{
			get { return IoC.Resolve<IMediaService>(); }
		}
	}
}
