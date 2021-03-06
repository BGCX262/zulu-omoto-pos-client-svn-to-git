﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using System.Threading;

namespace Zulu.BusinessService
{
	public partial class ZuluContext
	{
		#region Ctor
        /// <summary>
        /// Creates a new instance of the ZuluContext class
        /// </summary>
		private ZuluContext()
        {
        }
        #endregion

		#region Properties
		/// <summary>
		/// Gets an instance of the ZuluContext, which can be used to retrieve information about current context.
		/// </summary>
		public static ZuluContext Current
		{
			get
			{
				object data = Thread.GetData(Thread.GetNamedDataSlot("ZuluContext"));
				if (data != null)
				{
					return (ZuluContext)data;
				}
				ZuluContext context = new ZuluContext();
				Thread.SetData(Thread.GetNamedDataSlot("ZuluContext"), context);
				return context;
			}
		}

		public List<FormControl> FormControls {get; set;}

		public List<ButtonControl> ButtonControls {get; set;}

		public User CurrentUser { get; set; }

		public List<Product> Products { get; set; }

		public List<ProductVariant> ProductVariants { get; set; }

		public Sale Order { get; set; }

		#endregion
	}
}
