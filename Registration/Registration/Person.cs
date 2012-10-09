using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;

namespace Registration
{
	
	[DataContract]
	public class Person
	{

		private string login;
		private string password;
		private string age;
		private string country;
		private string security;

		private GameLibrary glib;
		public Person()
		{
			glib = new GameLibrary();
			login = "";
			password = "";
			age = "";
			country = "";
			security = "user";
		}
		[DataMember]
		public string Login
		{
			get { return login; }
			set { login = value; }
		}
		[DataMember]
		public string Security
		{
			get { return security; }
			set { security = value; }
		}

		[DataMember]
		public GameLibrary Glib
		{
			get { return glib; }
			set { glib = value; }
		}

		[DataMember]

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		[DataMember]

		public string Age
		{
			get { return age; }
			set { age = value; }
		}

		[DataMember]

		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		public Person(string _login, string _password, string _country, string _age)
		{
			login = _login;
			password = _password;
			age = _age;
			country = _country;
			glib = new GameLibrary();
			security = "user";
		}
		public string getLogin(){return login;}
		public string getPassword() { return password; }
		public string getAge() { return age; }
		public string getCountry() { return country; }
	}
}
