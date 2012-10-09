using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Registration
{
	public class MainControl
	{
		protected LogInForm form;
		protected Library libr;
		
		public MainControl()
		{
			string path="..\\..\\DataBase.json";
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			libr = new Library();
			string sJSON;
			System.Web.Script.Serialization.JavaScriptSerializer oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            System.IO.StreamReader file = new System.IO.StreamReader(path);
			while ((sJSON = file.ReadLine()) != null)
			{
				Person nana;
				nana = JsonConvert.DeserializeObject<Person>(sJSON);
				libr.Add(nana);
			}
			file.Close();
		}
		public void run(Form _form)
		{
			form = new LogInForm(this);
			Application.Run(form);
		}
		public void register()
		{
			RegistrationControl rControl = new RegistrationControl(libr);
			DialogResult dlgResult = rControl.Run(form);

			if (dlgResult == DialogResult.OK)
			{
				string path = "..\\..\\DataBase.json";
				System.Web.Script.Serialization.JavaScriptSerializer oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
				string sJSON = oSerializer.Serialize(rControl.getNewPerson());
				sJSON += "\n";
                File.AppendAllText(path, sJSON);

				libr.Add(rControl.getNewPerson());
			}

		}
		public bool validate(string t1, string t2)
		{
			bool toret = false;
			for (int i = 0; i < libr.size(); i++)
			{
				if ((t1 == libr.getLogin(i)) && (t2 == libr.getPassword(i)))
				{
					toret = true;
				}
			}
			return toret;
		}

		public void Shop(string t1, string t2)
		{
			Person temp = new Person();
			for (int i = 0; i < libr.size(); i++)
			{
				if ((t1 == libr.getLogin(i)))
				{
					temp = libr.Get(t1);
				}
			}

			ShopControl sControl = new ShopControl(temp, libr);
			DialogResult dlgResult = sControl.Run(form);
			if (dlgResult == DialogResult.OK)
			{
				form.reLogIn();
			}
			else
			{
				form.Close();
			}
		}

		public void Admin()
		{
			AdminFormController aControl = new AdminFormController(libr);
			DialogResult dlgResult = aControl.Run(form);
			if (dlgResult==DialogResult.OK)
			{
				libr = aControl.getLibr();
				string path = "..\\..\\DataBase.json";
				File.WriteAllText(path, "");
				System.Web.Script.Serialization.JavaScriptSerializer oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
				for (int i = 0; i < libr.Bracket.Count; i++)
				{
					string sJSON = oSerializer.Serialize(libr.Bracket[i]);
					sJSON += "\n";
					File.AppendAllText(path, sJSON);
				}
			}
		}

        public LogInForm getForm()
        {
            return form;
        }

        public string ComputeStringMD5Hash(string instr)
        {
            string strHash = string.Empty;

            foreach (byte b in new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(instr)))
            {
                strHash += b.ToString("X2");
            }
            return strHash;
        }

	}
}
