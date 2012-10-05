using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Registration
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			MainControl cntrl=new MainControl();
			cntrl.run(null);
		}
	}
}
