using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registration
{
	public class GameFormController
	{
		private GameForm gform;
		private Person user;
		private string t1;
		private string t2;
		private string t3;
		public GameFormController(Game game,Person _user,string _t1,string _t2,string _t3)
		{
			t1 = _t1;
			t2 = _t2;
			t3 = _t3;
			user = _user;
			gform=new GameForm(game,user,t1,t2,t3);
		}
		public GameFormController()
		{
			gform=new GameForm(this);
		}
		public DialogResult Run(Form _form)
		{
			return gform.ShowDialog(_form);
		}
	}
}
