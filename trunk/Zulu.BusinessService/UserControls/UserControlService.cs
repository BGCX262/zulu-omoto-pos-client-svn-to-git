using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.UserControls
{
	public partial class UserControlService : IUserControlService
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
		public UserControlService(ZuluDataContext context)
        {
            this._context = context;
        }


        #endregion

		#region FormControl

		public void SaveFormControl(FormControl formControl)
		{
			FormControl existingData = GetFormControlByID(formControl.FormID);

			if (existingData == null)
				_context.FormControls.AddObject(formControl);
			else
			{
				existingData.Name = formControl.Name;
				existingData.DisplayName = formControl.DisplayName;

				if (!_context.IsAttached(existingData))
					_context.FormControls.Attach(existingData);
			}

			_context.SaveChanges();
		}

		public FormControl GetFormControlByID(int formID)
		{
			return _context.FormControls.FirstOrDefault(c => c.FormID == formID);
		}

		public List<FormControl> GetAllFormControl()
		{
			return _context.FormControls.ToList();
		}

		#endregion

		#region ButtonControl

		public void SaveButtonControl(ButtonControl buttonControl)
		{
			ButtonControl existingData = GetButtonControlByID(buttonControl.ButtonID);

			if (existingData == null)
				_context.ButtonControls.AddObject(buttonControl);
			else
			{
				existingData.FormID = buttonControl.FormID;
				existingData.Name = buttonControl.Name;
				existingData.DisplayName = buttonControl.DisplayName;

				if (!_context.IsAttached(existingData))
					_context.ButtonControls.Attach(existingData);
			}

			_context.SaveChanges();
		}

		public ButtonControl GetButtonControlByID(int buttonID)
		{
			return _context.ButtonControls.FirstOrDefault(c => c.ButtonID == buttonID);
 
		}										   

		public List<ButtonControl> GetAllButtonControl()
		{
			return _context.ButtonControls.ToList();
		}

		#endregion
	}
}
