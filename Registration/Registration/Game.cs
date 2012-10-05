using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;

namespace Registration
{
	[DataContract]
	public class Game
	{
		private string name;

		public Game()
		{
			name = "";
		}
		public Game(string t1)
		{
			name = t1;
		}
		[DataMember]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}
