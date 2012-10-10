using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;

namespace Registration
{
	[DataContract]
	public class Indie:Game
	{
		protected string description;
		public Indie()
		{
			description = "";
			name = "";
		}
		public Indie(string _name, string _description)
		{
			name = _name;
			description = _description;
		}
		[DataMember]
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
	}
}
