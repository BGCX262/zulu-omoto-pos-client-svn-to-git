using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using System.Security.Cryptography;
using Zulu.BusinessService.Logs;
using Zulu.BusinessService.Infrastructure;

namespace Zulu.BusinessService.Data
{
	public partial class UserService : IUserService
	{
		#region Fields

        /// <summary>
        /// Object context
        /// </summary>
        private readonly ZuluDataContext _context;


        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context">Object context</param>
		public UserService(ZuluDataContext context)
        {
            this._context = context;
        }

        #endregion

		#region User
		
		public User GetUserByID(int userID)
		{
			return _context.Users.FirstOrDefault(c => c.UserID == userID);
		}

		public User GetUserByGUID(string userGUID)
		{
			Guid UserGUID = Guid.NewGuid();

			return _context.Users.FirstOrDefault(c => c.UserGUID == UserGUID);
		}

		public User GetUserByUserName(string UserName)
		{
			return _context.Users.FirstOrDefault(c => c.Username == UserName);
		}

		public List<User> GetAllUsers()
		{
			return _context.Users.ToList();
		}

		public List<User> GetAllActiveUser()
		{
			return _context.Users.Where(c => c.Active == true && c.Deleted == false).ToList();
		}

		public List<User> GetAllUsers(bool active, bool deleted)
		{
			return _context.Users.Where(c => c.Deleted == deleted && c.Active == active).ToList();
		}

		public List<User> GetAllDeletedUsers(bool deleted)
		{
			return _context.Users.Where(c => c.Deleted == deleted).ToList();
		}

		public List<User> GetAllActiveUsers(bool active)
		{
			return _context.Users.Where(c => c.Active == active).ToList();
		}


		public void SaveUser(User user)
		{
			string saltKey = CreateSalt(7);

			//Getting Encrypted password
			user.Salt = saltKey;
			user.PasswordHash = GetSHA1HashData(user.Password, saltKey);
			user.RegistrationDate = System.DateTime.Now;
			user.UpdatedDate = System.DateTime.Now;

			User existingData = GetUserByID(user.UserID);

			if (existingData == null)
			{
				user.UserGUID = Guid.NewGuid();
				_context.Users.AddObject(user);
			}
			else
			{
				existingData.UserGUID = Guid.NewGuid();
				existingData.UserRoleID = user.UserRoleID;
				existingData.MediaID = user.MediaID;
				existingData.FullName = user.FullName;
				existingData.Gender = user.Gender;
				existingData.NRCNumber = user.NRCNumber;
				existingData.Address1 = user.Address1;
				existingData.Address2 = user.Address2;
				existingData.PhoneNumber = user.PhoneNumber;
				existingData.EmailAddress = user.EmailAddress;
				existingData.Active = user.Active;
				existingData.Deleted = user.Deleted;
				existingData.UpdatedDate = user.UpdatedDate;
				existingData.DateOfBirth = user.DateOfBirth;
				existingData.IsMember = user.IsMember;

				if (!_context.IsAttached(existingData))
					_context.Users.Attach(existingData);
			}

			_context.SaveChanges();
		}

		public bool VerifyUser(string userName, string password)
		{
			User user = GetUserByUserName(userName);

			if (user == null)
				user = GetUserByGUID(userName);

			if (user == null || user.Deleted == true || user.Active == false)
				return false;

			string passwordHash = GetSHA1HashData(password, user.Salt);
			bool validate = passwordHash == user.PasswordHash;
			
			if (validate)
				ZuluContext.Current.CurrentUser = user;
			
			return validate;
		}

		public List<User> GetAllUserByUserRole(int userRoleID)
		{
			return _context.Users.Where(c => c.UserRoleID == userRoleID).ToList();
		}

		public bool ChangePassword(string username, string oldPassword, string newPassword)
		{
			User user = GetUserByUserName(username);

			if (user == null)
				return false;

			string passwordHash = GetSHA1HashData(oldPassword, user.Salt);
			bool validate = passwordHash == user.PasswordHash;

			if (validate)
			{
				string saltKey = CreateSalt(7);

				//Getting Encrypted password
				user.Salt = saltKey;
				user.PasswordHash = GetSHA1HashData(newPassword, saltKey);

				if (!_context.IsAttached(user))
					_context.Users.Attach(user);

				return true;
			}

			return false;
		}

		public bool ResetPassword(Guid userGUID, string newPassword)
		{
			User user = GetUserByUserName(userGUID.ToString());
			
			if (user == null)
				return false;
			try
			{
				string saltKey = CreateSalt(7);
				//Getting Encrypted password
				user.Salt = saltKey;
				user.PasswordHash = GetSHA1HashData(newPassword, saltKey);
				if (!_context.IsAttached(user))
					_context.Users.Attach(user);
				return true;
			}
			catch (Exception ex)
			{
				Log log = new Log();
				//TODO add data for log
				IoC.Resolve<ILogService>().InsertLog(log);
				return false;
			}
		}

		#endregion

		#region UserRole

		public UserRole GetUserRoleByID(int userRoleID)
		{
			return _context.UserRoles.FirstOrDefault(c => c.UserRoleID == userRoleID);
		}

		public List<UserRole> GetAllUserRoles()
		{
			return _context.UserRoles.ToList();
		}

		public List<UserRole> GetAllActiveUserRoles()
		{
			return _context.UserRoles.Where(c => c.IsActive == true).ToList();
		}

		public List<UserRole> GetAllUserRoles(bool isActive)
		{
			return _context.UserRoles.Where(c => c.IsActive == isActive).ToList();
		}

		public void SaveUserRole(UserRole userRole)
		{
			UserRole existingData = GetUserRoleByID(userRole.UserRoleID);

			if (existingData == null)
				_context.UserRoles.AddObject(userRole);
			else
			{
				existingData.Name = userRole.Name;
				existingData.IsActive = userRole.IsActive;
				existingData.UpdatedOn = System.DateTime.Now;

				if (!_context.IsAttached(existingData))
					_context.UserRoles.Attach(existingData);
			}

			_context.SaveChanges();
		}

		#endregion

		#region Custom Methods

		private string GetSHA1HashData(string password, string salt)
		{
			string dataToHash = password + salt;

			SHA1 sha1 = SHA1.Create();
			byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(dataToHash));
			StringBuilder returnValue = new StringBuilder();

			for (int i = 0; i < hashData.Length; i++)
			{
				returnValue.Append(hashData[i].ToString());
			}

			return returnValue.ToString();
		}

		private string CreateSalt(int size)
		{
			var provider = new RNGCryptoServiceProvider();
			byte[] data = new byte[size];
			provider.GetBytes(data);
			return Convert.ToBase64String(data);
		}

		#endregion

		#region UserAttribute

		public UserAttribute GetUserAttributeByID(int userAttributeID)
		{
			return _context.UserAttributes.FirstOrDefault(c => c.UserAttributeID == userAttributeID);
		}

		public UserAttribute GetUserAttributeByUserIDAndKey(int userID, string key)
		{
			return _context.UserAttributes.FirstOrDefault(c => c.UserID == userID && c.AttributeKey == key);
		}
		
		public List<UserAttribute> GetAllUserAttributes(int userID)
		{
			return _context.UserAttributes.Where(c => c.UserID == userID).ToList();
		}

		public void SaveUserAttributes(UserAttribute userAttribute)
		{
			int useID = 0;
			int.TryParse(userAttribute.UserID.ToString(), out useID);

			UserAttribute existingData = GetUserAttributeByUserIDAndKey(useID, userAttribute.AttributeKey);

			if (existingData == null)
				_context.UserAttributes.AddObject(userAttribute);
			else
			{
				existingData.Value = userAttribute.Value;

				if (!_context.IsAttached(existingData))
					_context.UserAttributes.Attach(existingData);
			}

			_context.SaveChanges();
		}

		#endregion

		#region UserRole Attribute

		public UserRoleAttribute GetUserRoleAttributeByID(int userRoleAttributeID)
		{
			return _context.UserRoleAttributes.FirstOrDefault(c => c.UserRoleAttributeID == userRoleAttributeID);
		}

		public UserRoleAttribute GetUserRoleAttributeByUserIDAndKey(int userRoleID, string key)
		{
			return _context.UserRoleAttributes.FirstOrDefault(c => c.UserRoleID == userRoleID && c.AttributeKey == key);
		}

		public List<UserRoleAttribute> GetAllUserRoleAttributes(int userRoleID)
		{
			return _context.UserRoleAttributes.Where(c => c.UserRoleID == userRoleID).ToList();
		}

		public void SaveUserRoleAttributes(UserRoleAttribute userRoleAttribute)
		{
			int useID = 0;
			int.TryParse(userRoleAttribute.UserRoleID.ToString(), out useID);

			UserRoleAttribute existingData = GetUserRoleAttributeByUserIDAndKey(useID, userRoleAttribute.AttributeKey);

			if (existingData == null)
				_context.UserRoleAttributes.AddObject(userRoleAttribute);
			else
			{
				existingData.Value = userRoleAttribute.Value;

				if (!_context.IsAttached(existingData))
					_context.UserRoleAttributes.Attach(existingData);
			}

			_context.SaveChanges();
		}
		#endregion
	}
}
