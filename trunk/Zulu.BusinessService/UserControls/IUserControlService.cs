using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.UserControls
{
	public partial interface IUserControlService
	{
		#region FormControl

		void SaveFormControl(FormControl formControl);

		FormControl GetFormControlByID(int FormControlID);

		List<FormControl> GetAllFormControl();

		#endregion

		#region ButtonControl

		void SaveButtonControl(ButtonControl buttonControl);

		ButtonControl GetButtonControlByID(int buttonControlID);

		List<ButtonControl> GetAllButtonControl();

		#endregion

	}
}
