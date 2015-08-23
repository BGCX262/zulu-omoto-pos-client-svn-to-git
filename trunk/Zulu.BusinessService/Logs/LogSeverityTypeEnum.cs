using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zulu.BusinessService.Logs
{
	public enum LogSeverityTypeEnum : int
	{
		/// <summary>
		/// Unknown
		/// </summary>
		Unknown = 1,

		/// <summary>
		/// User update
		/// </summary>
		UserUpdate = 2,

		/// <summary>
		/// User Error
		/// </summary>
		UserError = 3,

		/// <summary>
		/// System Crash
		/// </summary>
		SystemCrash = 4
	}
}
