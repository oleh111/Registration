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
		protected string path;
		protected string icon;
		public Indie()
		{
			description = "";
			name = "";
		}
		public Indie(string _name, string _description,string _path,string _icon)
		{
			name = _name;
			path = _path;
			description = _description;
			icon = _icon;
		}
		[DataMember]
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
		[DataMember]
		public string Icon
		{
			get { return icon; }
			set { icon = value; }
		}
		[DataMember]
		public string Path
		{
			get { return path; }
			set { path = value; }
		}
	}
}
