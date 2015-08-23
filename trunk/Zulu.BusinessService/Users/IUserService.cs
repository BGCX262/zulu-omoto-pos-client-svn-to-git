using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Data
{
	public partial interface IUserService
	{
		#region User

		User GetUserByID(int userID);

		User GetUserByGUID(string userGUID);

		User GetUserByUserName(string UserName);

		List<User> GetAllUsers();

		void SaveUser(User user);

		bool VerifyUser(string userName, string password);

		bool ChangePassword(string username, string oldPassword, string newPassword);

        bool ResetPassword(Guid userGUID, string newPassword);

		List<User> GetAllActiveUser();

		List<User> GetAllUsers(bool active, bool deleted);

		List<User> GetAllActiveUsers (bool active);

		List<User> GetAllDeletedUsers(bool deleted);

		List<UserRole> GetAllActiveUserRoles();

		List<UserRole> GetAllUserRoles(bool isActive);

		#endregion

		#region UserRole

		UserRole GetUserRoleByID(int userRoleID);

		List<UserRole> GetAllUserRoles();

		void SaveUserRole(UserRole userRole);

		List<User> GetAllUserByUserRole(int userRoleID);

		#endregion

		#region UserAttribute

		UserAttribute GetUserAttributeByID(int userAttributeID);

		void SaveUserAttributes(UserAttribute userAttribute);

		UserAttribute GetUserAttributeByUserIDAndKey(int userID, string key);

		List<UserAttribute> GetAllUserAttributes(int userID);

		#endregion

		#region UserRoleAttribute

		UserRoleAttribute GetUserRoleAttributeByID(int userRoleAttributeID);

		void SaveUserRoleAttributes(UserRoleAttribute userRoleAttribute);

		UserRoleAttribute GetUserRoleAttributeByUserIDAndKey(int userRoleID, string key);

		List<UserRoleAttribute> GetAllUserRoleAttributes(int userRoleID);

		#endregion

	}
}
