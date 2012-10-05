using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;

namespace Registration
{
	[DataContract]
	public class GameLibrary
	{
		protected List<Game> bracket;
		public void Copy(List<Game> atr)
		{
			bracket = atr;
		}
		public bool find(string id)
		{
			for (int i = 0; i < Bracket.Count; i++)
			{
				if (Bracket[i].Name == id)
				{
					return true;
				}
			}
			return false;
			Exception exception = new Exception("fail");
			throw (exception);
		}
		[DataMember]
		public List<Game> Bracket
		{
			get { return bracket; }
			set { bracket = Bracket; }
		}

		public GameLibrary()
		{
			bracket = new List<Game>();
		}
		public bool Empty()
		{
			if (bracket.Count == 0)
			{
				return true;
			}
			return false;
		}
		public GameLibrary(List<Game> _bracket)
		{
			bracket = new List<Game>(_bracket);
		}

		public void Add(Game Game)
		{
			bracket.Add(Game);
		}

		public void Delete(string id)
		{
			for (int i = 0; i < bracket.Count; i++)
			{
				if (bracket[i].Name == id)
				{
					bracket.Remove(bracket[i]);
				}
			}
		}

		public void Set(Game Game)
		{
			for (int i = 0; i < bracket.Count; i++)
			{
				if (bracket[i].Name == Game.Name)
				{
					bracket[i] = Game;
				}
			}
		}
		public Game getByIndex(int i)
		{
			return bracket[i];
		}
		public Game Get(string id)
		{
			for (int i = 0; i < bracket.Count; i++)
			{
				if (bracket[i].Name == id)
				{
					return bracket[i];
				}
			}
			return new Game();
		}
		public Game Get(int i)
		{
			return bracket[i];
		}
		public int size()
		{
			return bracket.Count;
		}
		public string getName(int i)
		{
			return bracket[i].Name;
		}
	}
}
