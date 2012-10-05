using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registration
{
	class Date
	{
		private string month;
		private string year;

		public Date(string m, string y)
		{
			month = m;
			year = y;
		}
		public string output()
		{
			return month + "/" + year;
		}
	}
}
