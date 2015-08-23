using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Configuration;
using ZuluPOSClient;
using ZuluPOSClient.Testing;
using Zulu.BusinessService;
using Zulu.BusinessService.UserControls;
using ZuluPOSClient.Forms;
using ZuluPOSClient.Products;
using ZuluPOSClient.Users;
using ZuluPOSClient.Sales;
using ZuluPOSClient.Damage;

namespace Zulu.PointOfSaleManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ZuluConfig.Init();
            IoC.InitializeWith(new DependencyResolverFactory());

			ZuluContext.Current.FormControls = IoC.Resolve<IUserControlService>().GetAllFormControl();
			ZuluContext.Current.ButtonControls = IoC.Resolve<IUserControlService>().GetAllButtonControl();

            Application.Run(new Testing1());
        }
    }
}
