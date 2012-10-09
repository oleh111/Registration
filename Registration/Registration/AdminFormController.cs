using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registration
{
	public class AdminFormController
	{
		private AdminForm af;
		protected Library libr;
		public AdminFormController(Library _libr)
		{
			libr = _libr;
		}
		public AdminFormController()
		{ 
		}
		public DialogResult Run(Form _form)
		{
			af = new AdminForm(libr);
			return af.ShowDialog(_form);
		}
		public Library getLibr()
		{
			return af.getLib();
		}
	}
}
