using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registration
{
	public class ShopControl
	{
		private Person user;
		private ShopForm sform;
		private Library lib;

		public ShopControl(Person _user,Library _lib)
		{
			lib=_lib;
			user = _user;
			sform = new ShopForm(this,user,lib);
		}

		public DialogResult Run(Form _form)
		{
			return sform.ShowDialog(_form);
		}
		public string onLoadShop()
		{
			string toReturn = user.Login;
			for (int i = 0; i < toReturn.Length; i++)
			{
				if (toReturn[i] == '@')
				{
					toReturn=toReturn.Remove(i, toReturn.Length - i);
				}
			}
			return toReturn;
		}
	}
}
