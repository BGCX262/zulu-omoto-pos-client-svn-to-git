using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;
using System.Configuration;

namespace Zulu.BusinessService.Settings
{
	/// <summary>
	/// Represents ApplicationSetting
	/// </summary>
	public partial class ApplicationSetting
	{
		public static string BranchID
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.BranchID");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.BranchID", "1", "Branch ID");

				return setting.Value;
			}
		}

		public static string BranchType
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.BranchType");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.BranchType", "Branch Type", "BranchType");

				return setting.Value;
			}
		}

		public static string Address1
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Address1");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Address1", "Address1", "Address1");

				return setting.Value;
			}
		}

		public static string Address2
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Address2");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Address2", "Address2", "Address2");

				return setting.Value;
			}
		}

		public static string Phone
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Phone");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Phone", "Phone", "Phone");

				return setting.Value;
			}
		}

		public static string Email
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Email");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Email", "Email", "Email");

				return setting.Value;
			}
		}

		public static string State
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.State");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.State", "State", "State");

				return setting.Value;
			}
		}

		public static string City
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.City");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.City", "City", "City");

				return setting.Value;
			}
		}

		/// <summary>
		/// Gets the client ID from the config file
		/// </summary>
		public static string ClientID
		{
			get
			{
				return ConfigurationManager.AppSettings["ClientID"];
			}
		}

		/// <summary>
		/// Gets the short date of today
		/// </summary>
		public static string TodayShortDate
		{
			get
			{
				return System.DateTime.Now.ToString("ddMMyy");
			}
		}

		/// <summary>
		/// Gets the base voucher number
		/// </summary>
		public static string BaseVoucherNumber
		{
			get
			{
				return BranchID + TodayShortDate + ClientID;
			}

		}
	}
}
