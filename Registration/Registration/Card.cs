using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registration
{
	class Card
	{
		private string number;
		private Date date;
		private string CVV;

		public Card()
		{
		}

		public void setNumber(string n)
		{
			number = n;
		}
		public void setCVV(string a)
		{
			CVV = a;
		}
		public void setDate(string months, string year)
		{
			date = new Date(months, year);
		}
		public bool allGoog(string n, string m, string y, string c)
		{
			bool toReturn = true;

			foreach (char a in c)
			{
				if (!(a >= 0 && a <= 9))
				{
					toReturn = false;
				}
			}
			foreach (char a in n)
			{
				if (!(a >= 0 && a <= 9))
				{
					toReturn = false;
				}
			}
			return toReturn;
		}
		public void writeInFile()
		{
			System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Oleh\Documents\Visual Studio 2010\Projects\Payment\Payment\Resources\Cards.txt", true);
			string line = number + " " + date.output() + " " + CVV;
			file.WriteLine(line);
			file.Close();
		}
	}
}
