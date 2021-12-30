using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models.Infrastructores
{
    public class ConnstringProvider
    {
		private static string connStr = "";

		public static string Value
		{
			get
			{
				if (string.IsNullOrEmpty(connStr))
				{
					connStr = System.Configuration.ConfigurationManager.ConnectionStrings["DBconnect"].ToString();
				}

				return connStr;
			}

		}

	}
}