using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registration
{
	public class Library
	{
		protected List<Person> bracket;
		public void Copy(List<Person> atr)
		{
			bracket = atr;
		}
		public bool find(string id)
		{
			for (int i = 0; i < Bracket.Count; i++)
			{
				if (Bracket[i].Login == id)
				{
					return true;
				}
			}
			return false;
			Exception exception = new Exception("fail");
			throw (exception);
		}

		public Person getByIndex(int i)
		{
			return bracket[i];
		}
		public List<Person> Bracket
		{
			get { return bracket; }
			set { bracket = Bracket; }
		}

		public Library()
		{
			bracket = new List<Person>();
		}
		public bool Empty()
		{
			if (bracket.Count == 0)
			{
				return true;
			}
			return false;
		}
		public Library(List<Person> _bracket)
		{
			bracket = new List<Person>(_bracket);
		}

		public void Add(Person Person)
		{
			bracket.Add(Person);
		}

		public void Delete(string id)
		{
			for (int i = 0; i < bracket.Count; i++)
			{
				if (bracket[i].Login == id)
				{
					bracket.Remove(bracket[i]);
				}
			}
		}

		public void Set(Person Person)
		{
			for (int i = 0; i < bracket.Count; i++)
			{
				if (bracket[i].Login == Person.Login)
				{
					bracket[i] = Person;
				}
			}
		}

		public Person Get(string id)
		{
			for (int i = 0; i < bracket.Count; i++)
			{
				if (bracket[i].Login == id)
				{
					return bracket[i];
				}
			}
			return new Person();
		}
		public int size()
		{
			return bracket.Count;
		}
		public string getLogin(int i)
		{
			return bracket[i].Login;
		}
		public string getPassword(int i)
		{
			return bracket[i].Password;
		}
	}
}
