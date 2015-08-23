using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.UserControls;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Products;
using Zulu.BusinessService;
using Zulu.BusinessService.Sales;
using Zulu.BusinessService.Settings;
using Zulu.BusinessService.StorageMedia;


namespace ZuluPOSClient.Controls
{
    public partial class BaseZuluFormControl : Form
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseZuluFormControl
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.Name = "BaseZuluFormControl";
            this.ResumeLayout(false);
            //var test = ZuluContext.Current.CurrentUser.RestrictedFormControls.ToList();
        }

	
 
    }
}
