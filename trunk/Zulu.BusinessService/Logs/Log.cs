using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Data
{
	public partial class Log
	{
		#region Custom Properties

		public User User
		{
			get
			{
				int userID = 0;
				int.TryParse(this.UserID.ToString(), out userID);

				return IoC.Resolve<IUserService>().GetUserByID(userID);
			}
		}

		#endregion
	}
}
