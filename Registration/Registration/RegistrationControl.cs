using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace Registration
{
	public class RegistrationControl
	{
		private RegistrationForm rform;
		private Library libr;
        private string text = String.Empty;
	    private Person newPerson;
		public void setText(string _text)
		{
			text=_text;
		}

		public RegistrationControl(Library _libr)
		{
			libr = _libr;
			rform = new RegistrationForm(this);
		}
		public DialogResult Run(Form _form)
		{
			return rform.ShowDialog(_form);
		}
		public string validateTextBox1(string _login)
		{
			string toReturn="Email needs @";
            bool sobaka = false;
            int letterCount = 0;
            bool containPoint = false;
           
            for (int i = 0; i < _login.Length; i++)
            {
                if (libr.find(_login))
                {
                    return "Exist";
                }
            }

			for (int i = 1; i < _login.Length; i++)
			{
				//треба нормальну перевірку буде зробити ще
                if (_login[i] == ' ')
                {
                    return "Email needs @";
                }
                if (sobaka == true)
                {
                    if (_login[i] == '.')
                    {
                        containPoint = true;
                    }
                    else
                    {
                        letterCount++;
                    }
                }
                else
                {
                    if (_login[i] == '@')
                    {
                        sobaka = true;
                    }
                }
			}

            if (sobaka == true && containPoint == true && letterCount >= 2)
            {
                return "OK";
            }
            else
            {
                return "Email needs @";
            }
		}
		public bool validateTextBox2(string _password1,string _password2)
		{
			return (_password1 == _password2);
		}
		public bool validateComboBox1(string country)
		{
			return (country == "");
		}
		public bool validatecomboBox2(string age)
		{

			return ((age != "")&& (Convert.ToInt32(age) <= 1995));
		}
		public bool registerComplete(string p1,string p2,string p3,string p4)
		{
			return ((p1 == "Acceptable") && (p2 == "Acceptable") && (p3 == "Acceptable") && (p4 == "Acceptable"));
		}
		public void createPerson(string p1, string p2, string p3, string p4)
		{
			newPerson = new Person(p1, p2, p3, p4);
		}
		public Person getNewPerson()
		{
			return newPerson;
		}
        public Bitmap createImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            //int Xpos = rnd.Next(0, Width - 50);
            //int Ypos = rnd.Next(15, Height - 15);
            int Xpos = rnd.Next(0, 0);
            int Ypos = rnd.Next(0, 0);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Lime,
                     Brushes.Aqua,
                     Brushes.Pink,
                     Brushes.Yellow };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Black);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 3; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 30),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            /*g.DrawLine(Pens.White,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.White,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));*/

            for (int i = 0; i < rnd.Next() % 100; ++i)
            {
                g.DrawLine(Pens.White,
                       new Point(rnd.Next() % Width, rnd.Next() % Height),
                       new Point(rnd.Next() % Width, rnd.Next() % Height));
            }
            for (int i = 0; i < rnd.Next() % 100; ++i)
            {
                g.DrawLine(Pens.Black,
                       new Point(rnd.Next() % Width, rnd.Next() % Height),
                       new Point(rnd.Next() % Width, rnd.Next() % Height));
            }
            for (int i = 0; i < rnd.Next() % 100; ++i)
            {
                g.DrawLine(Pens.Brown,
                       new Point(rnd.Next() % Width, rnd.Next() % Height),
                       new Point(rnd.Next() % Width, rnd.Next() % Height));
            }

            ////Белые точки
            /*for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);*/

            return result;
        }
        public bool checkCaptcha(string _text)
        {
            if (text == _text)
            {
                return true;
            }
            return false;
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
