using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing.Drawing2D;

namespace Registration
{
	public partial class ShopForm : Form
	{
		private ShopControl sControl;
		private List<PictureBox> pblist;
		private List<PictureBox> pblist1;
		private List<Label> llist;
		private List<string> t1;
		private List<string> t2;
		private List<string> t3;
		private Person user;
		private Library libr;
		private GameLibrary glibr;
		private bool Move;
		private int X;
		private int Y;
		private int koeficient;
		private int n;
		private List<Label> newgameList;

		public ShopForm(ShopControl _sControl,Person _user,Library _libr)
		{
			initializeTabPage3();
			newgameList = new List<Label>();
			glibr = new GameLibrary();
			glibr.Add(new Game("Team Fortress 2"));
			glibr.Add(new Game("Star Craft 2"));
			glibr.Add(new Game("Half life 2"));
			glibr.Add(new Game("Portal"));
			glibr.Add(new Game("World of Warcraft"));
			glibr.Add(new Game("Heroes 6"));
			glibr.Add(new Game("Dark Sides 2"));
			glibr.Add(new Game("Black Mesa"));
			glibr.Add(new Game("Dota2"));
			glibr.Add(new Game("Witcher"));
			glibr.Add(new Game("Battle Field 3"));
			glibr.Add(new Game("Diablo 3"));
			libr = _libr;
			user = _user;
			sControl = _sControl;
			InitializeComponent();
			tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
			t1 = new List<string>();
			t2 = new List<string>();
			t3 = new List<string>();
			label1.Text = "Hello,";
			label1.Text += sControl.onLoadShop();
			pblist = new List<PictureBox>();
			pblist1 = new List<PictureBox>();
			llist = new List<Label>();
			n = 0;
			pblist.Add(pictureBox6);
			pblist.Add(pictureBox7);
			pblist.Add(pictureBox8);
			pblist.Add(pictureBox9);
			pblist.Add(pictureBox10);
			pblist.Add(pictureBox11);
			pblist.Add(pictureBox12);
			pblist.Add(pictureBox13);
			pblist.Add(pictureBox14);
			pblist.Add(pictureBox15);
			pblist.Add(pictureBox16);
			pblist.Add(pictureBox17);
			koeficient = (int)(SystemInformation.PrimaryMonitorSize.Height/1024);
			List<string> text=new List<string>();
			text.Add("Team Fortress 2 - innovating roleplay shooter.\n In game you can choose one of 8 roles. \n medic,heavy,scout,demoman,soldair,engineer,spy, and sniper.\n Each of them has own changeble weapons and history. \n There are lots of different types and game modes,maps and missions.\n You will be defending castles, deathmatching, storming and capturing flags!\n\n\n So if you want to have fun in Team fortress 2 order it now.");
			text.Add("StarCraft 2 - Chalenging RTS, next chapter of SC\n Nowadays SC2 is the most popular eSport game\n Most exciting game tournaments, epic battles and mindgames are here\n\n For people who came to see next chapter of Raynor's story Starcraft2 \n has a lot to see nad play in new campaign. \n There are still 3 different sides in space war: Zergs,Protoss,Terran\n You will be excited by comanding space marines \n or invading worlds with your swarm \n\n\n So if you want to have fun in Starcraft 2 order it now.");
			text.Add("Half-Life 2: Episode Two is a first-person shooter video game \n the second episode in a series of sequels to the 2004 Half-Life 2. \n It was developed by Valve Corporation in tandem with Episode One, \n the first game in the series, and released in 2007 \n via Valve's Steam content distribution platform. \n The episode was released both separately and as a part of a bundled package \n The Orange Box. \n\n\n So if you want to play Half life,order it now.");
			text.Add("Portal is a 2007 single-player first-person puzzle-platform video game \n developed by Valve Corporation. \n The game was released in a bundle package called The Orange Box \n for Microsoft Windows and Xbox 360 on October 9, 2007,\n and for the PlayStation 3 on December 11, 2007. \n The Windows version of the game is available for download \n separately through Valve's content delivery system Steam \n and was released as a standalone retail product on April 9, 2008.\n A standalone version called Portal: Still Alive \n was released on the Xbox Live Arcade service on October 22, 2008;\n this version includes an additional 14 puzzles. \n A Mac OS X version was released as part of the Mac-compatible Steam \n\n\n So if you want to play Portal, order it now!");	
			text.Add("World of Warcraft (often abbreviated as WoW)\n is a massively multiplayer online role-playing game \n It is the fourth released game set in the fantasy Warcraft universe,\n which was first introduced by Warcraft:\n Orcs & Humans in 1994.\n World of Warcraft takes place within the Warcraft world of Azeroth,\n approximately four years after the events at the conclusion \n of Blizzard's previous Warcraft release, Warcraft III: The Frozen Throne \n\n\n  So if you want to have fun in WoW order it now.");
			text.Add("Might & Magic Heroes VI is a turn-based strategy video game \n for Microsoft Windows developed by Black Hole Entertainment \n and published by Ubisoft. \n It is the sixth installment in the Heroes of Might and Magic series,\n and was released on October 13, 2011, \n coinciding with the 25th anniversary of the Might and Magic franchise. \n Heroes VI acts as a prequel to Heroes of Might and Magic V,\n occurring almost five centuries earlier, \n and is set in the fictional world of Ashan. \n The story follows the five heirs to the Griffin dynasty \n in their quests to repel a demon invasion and assist  \n or impede Michael, a legendary Archangel general plotting \n to revive an ancient war.\n\n\n So if you want to play Heroes6 , order it now!");
			text.Add("Darksiders II is an action-adventure and action role-playing game \n developed by Vigil Games and published by THQ. \n It is the sequel to Darksiders\n and was released in August 2012 for PlayStation 3,\n Xbox 360, Microsoft Windows, with a Wii U port scheduled \n later in the year.\n\n\nSo if you want to play Darksides2 , order it now!");
			text.Add("Black Mesa (previously known as Black Mesa: Source) \n is a third-party total conversion modification  \n for Valve Corporation's Source engine. \n The stated goal of the project is to recreate Valve's critically acclaimed \n 1998 video game Half-Life using the more advanced capabilities \n of the Source engine. The 40-person volunteer development team says they \n hope to create a more engrossing in-game world with more varied, \n complex environments and more challenging, realistic gameplay. \n\n\n So if you want to play BlackMesa, order it now!");
			text.Add("Dota 2 is an upcoming multiplayer online battle arena video game \n being developed by Valve Corporation and the stand-alone sequel to popular \n Defense of the Ancients mod for Warcraft III: Reign of Chaos \n and its expansion pack, The Frozen Throne. \n Formally announced on October 13, 2010, via Game Informer, \n the game is currently available for early test access purchase \n and is scheduled for a full release in 2012, \n with a free-to-play business model.\n\n\n So if you want to play Dota2 ,order it now!");
			text.Add("The Witcher is an action role-playing video game  \n developed by CD Projekt RED and published by Atari. \n The game is based on the book series by Polish author Andrzej Sapkowski.\n The Witcher takes place in a medieval fantasy world and follows the story of Geralt, \n one of a few remaining witchers – traveling monster hunter for hire,\n gifted with unnatural powers. The game's system of 'moral choices' \n as part of the storyline was noted for its time-delayed \n consequences and lack of black-and-white morality.\n\n\n So if you want ot play Witcher, order it now!");
			text.Add("Battlefield 3 (commonly abbreviated BF3) is a first-person shooter video game \n developed by EA Digital Illusions CE and published by Electronic Arts.\n It is a direct sequel to 2005's Battlefield 2, \n and the twelfth installment in the Battlefield franchise. \n\n\n So if you want to play Battle field 3 - order it now!");
			text.Add("Diablo III is an action role-playing hack and slash video game \n developed and published by Blizzard Entertainment. \n It is the third installment in the Diablo franchise.\n The game, which features elements of the hack and slash genre, \n was released in North America, Latin America, Europe, South Korea, and Taiwan\n  on May 15, 2012, and in Russia on June 7, 2012.\n Before its release, the game broke several presale records \n and became the most pre-ordered PC game to date on Amazon.com.\n Diablo III subsequently set the new all-time record \n for fastest-selling PC game by selling over 3.5 million copies  \n in the first 24 hours of its release. \n\n\n So by it immidiately !!!");
			
			this.label1.Location = new System.Drawing.Point((SystemInformation.PrimaryMonitorSize.Width - 200), 100);
			this.label2.Location = new System.Drawing.Point((SystemInformation.PrimaryMonitorSize.Width - 200), 120);
			this.label16.Location = new System.Drawing.Point((SystemInformation.PrimaryMonitorSize.Width - 20), 10);
			this.label15.Location = new System.Drawing.Point((SystemInformation.PrimaryMonitorSize.Width - 40), 10);
			this.tabControl1.Location = new System.Drawing.Point((int)((SystemInformation.PrimaryMonitorSize.Width - (SystemInformation.PrimaryMonitorSize.Height * 1.25*0.728)) / 2), (int)(SystemInformation.PrimaryMonitorSize.Height * 0.205));
			this.tabControl1.Size = new System.Drawing.Size((int)(SystemInformation.PrimaryMonitorSize.Height * 1.25 * 0.728), (int)(SystemInformation.PrimaryMonitorSize.Height * 0.72));
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			for (int i = 0; i < pblist.Count; i++)
			{
				int k = i;
				int j = 0;
				if (i >= 6)
				{
					k = i - 6;
					j = 152*koeficient;
				}
				string path = "..\\..\\pictures\\";
				pblist[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				pblist[i].Location = new System.Drawing.Point(10 + k * 150 * koeficient, 400*koeficient+j);
				pblist[i].Name = (i).ToString();
				pblist[i].Size = new System.Drawing.Size(150, 150);
				pblist[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				pblist[i].TabIndex = 10;
				pblist[i].TabStop = false;
				string src = path + i.ToString() + ".jpg";
				Image image = Image.FromFile(src);
				pblist[i].Image = image;
				pblist[i].MouseEnter += new System.EventHandler(this.pictureBoxi_MouseEnter);
				pblist[i].MouseLeave += new System.EventHandler(this.pictureBoxi_MouseLeave);
				pblist[i].Click += new System.EventHandler(this.pictureBoxi_Click);
				src = path + i.ToString() + i.ToString()  + ".png";
				string src3 = path + i.ToString() + i.ToString() + i.ToString() + ".png";
				t1.Add(src);
				t2.Add(text[i]);
				t3.Add(src3);
				//initializeTabPage2();
			}
			initializeTabPage2();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void ShopForm_MouseUp(object sender, MouseEventArgs e)
		{
			Move = false;
		}

		private void ShopForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (Move)
			{
				this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
			}
		}

		private void ShopForm_MouseDown(object sender, MouseEventArgs e)
		{
			Move = true;
			X = e.X;
			Y = e.Y;
		}

		private void ShopForm_Load(object sender, EventArgs e)
		{
			timer1.Start();
			button1.TabStop = false;
			CancelButton = button1;
		}

		private void timerPage1()
		{
			n++;
			if ((n <= 808) && (n > 500))
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
				pictureBox2.Location = new Point(pictureBox2.Location.X - 1, pictureBox2.Location.Y);
				pictureBox3.Location = new Point(pictureBox3.Location.X - 1, pictureBox3.Location.Y);
				pictureBox4.Location = new Point(pictureBox4.Location.X - 1, pictureBox4.Location.Y);
				pictureBox5.Location = new Point(pictureBox5.Location.X - 1, pictureBox5.Location.Y);
			}
			if (n == 808) { n = 0; }
			if (pictureBox1.Location.X == -308)
			{
				pictureBox1.Location = new Point(1232, 62);
			}
			if (pictureBox2.Location.X == -308)
			{
				pictureBox2.Location = new Point(1232, 62);
			}
			if (pictureBox3.Location.X == -308)
			{
				pictureBox3.Location = new Point(1232, 62);
			}
			if (pictureBox4.Location.X == -308)
			{
				pictureBox4.Location = new Point(1232, 62);
			}
			if (pictureBox5.Location.X == -308)
			{
				pictureBox5.Location = new Point(1232, 62);
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
		}
		private void timerPage2()
		{

			if (pblist1[0].Location.X != 130) { pblist1[0].Location = new Point(pblist1[0].Location.X + 40, pblist1[0].Location.Y); }
			else
			{
				if (pblist1[1].Location.X != 130) { pblist1[1].Location = new Point(pblist1[1].Location.X + 40, pblist1[1].Location.Y); }
				else
				{
					if (pblist1[2].Location.X != 130) { pblist1[2].Location = new Point(pblist1[2].Location.X + 40, pblist1[2].Location.Y); }
					else
					{
						if (pblist1[3].Location.X != 130) { pblist1[3].Location = new Point(pblist1[3].Location.X + 40, pblist1[3].Location.Y); }
						else
						{
							if (pblist1[4].Location.X != 410) { pblist1[4].Location = new Point(pblist1[4].Location.X + 40, pblist1[4].Location.Y); }
							else
							{
								if (pblist1[5].Location.X != 410) { pblist1[5].Location = new Point(pblist1[5].Location.X + 40, pblist1[5].Location.Y); }
								else
								{
									if (pblist1[6].Location.X != 410) { pblist1[6].Location = new Point(pblist1[6].Location.X + 40, pblist1[6].Location.Y); }
									else
									{
										if (pblist1[7].Location.X != 410) { pblist1[7].Location = new Point(pblist1[7].Location.X + 40, pblist1[7].Location.Y); }
										else
										{
											if (pblist1[8].Location.X != 730) { pblist1[8].Location = new Point(pblist1[8].Location.X + 40, pblist1[8].Location.Y); }
											else
											{
												if (pblist1[9].Location.X != 730) { pblist1[9].Location = new Point(pblist1[9].Location.X + 40, pblist1[9].Location.Y); }
												else
												{
													if (pblist1[10].Location.X != 730) { pblist1[10].Location = new Point(pblist1[10].Location.X + 40, pblist1[10].Location.Y); }
													else
													{
														if (pblist1[11].Location.X != 730) { pblist1[11].Location = new Point(pblist1[11].Location.X + 40, pblist1[11].Location.Y); }
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			timerPage1();
			timerPage2();
		}

		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{

		}

		private void pictureBoxi_MouseEnter(object sender, EventArgs e)
		{
			PictureBox Caller = sender as PictureBox;
			if ((Caller.Name != "0")&&(Caller.Name != "6"))
			{
				Caller.Location = new System.Drawing.Point(Caller.Location.X - 150, Caller.Location.Y - 150);
			}
			else
			{
				Caller.Location = new System.Drawing.Point(Caller.Location.X, Caller.Location.Y - 150);
			}
			Caller.Size = new System.Drawing.Size(300, 300);

			Caller.BringToFront();
		}
		private void pictureBoxi_MouseLeave(object sender, EventArgs e)
		{
			PictureBox Caller = sender as PictureBox;
			if ((Caller.Name != "0")&&(Caller.Name != "6"))
			{
				Caller.Location = new System.Drawing.Point(Caller.Location.X + 150, Caller.Location.Y + 150);
			}
			else
			{
				Caller.Location = new System.Drawing.Point(Caller.Location.X, Caller.Location.Y + 150);
			}
			Caller.Size = new System.Drawing.Size(150, 150);
		}

		private void Buy(int i)
		{
			GameFormController gfcntrl = new GameFormController(glibr.Get(i), user, t1[i], t2[i], t3[i]);
			DialogResult dlgResult = gfcntrl.Run(this);
			if (dlgResult == DialogResult.OK)
			{
				string path = "..\\..\\DataBase.json";
				user.Glib.Add(glibr.Get(i));
				libr.Set(user);
				System.Web.Script.Serialization.JavaScriptSerializer oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
				File.WriteAllText(path, "");
				for (int j = 0; j < libr.size(); j++)
				{
					string sJSON = oSerializer.Serialize(libr.getByIndex(j));
					sJSON += "\n";
					File.AppendAllText(path, sJSON);

				}
				initializeTabPage2();
			}
		}

		private void pictureBoxi_Click (object sender, EventArgs e)
		{
			//не дуже мвс,але всеодно
			PictureBox Caller = sender as PictureBox;
			int i = Int32.Parse(Caller.Name);
			Buy(i);
		}
		//мда
		public int Times=0;
		private void BoughtPictures_Click(object sender, EventArgs e)
		{
			/*if (Times == 0)
			{*/
				PictureBox Caller = sender as PictureBox;
				string name = Caller.Name;
				int i = ConvertNameIntoNumbaNiggazYo(name);
				Buy(i);
			/*}
			Times++;
			if (Times == 13) { Times = 0; }*/
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void tabControl1_DrawItem(object sender,
		System.Windows.Forms.DrawItemEventArgs e)
		{
			Graphics g = e.Graphics;
			Brush _TextBrush;

			// Get the item from the collection.
			TabPage _TabPage = tabControl1.TabPages[e.Index];

			// Get the real bounds for the tab rectangle.
			Rectangle _TabBounds = tabControl1.GetTabRect(e.Index);

			if (e.State == DrawItemState.Selected)
			{
				// Draw a different background color, and don't paint a focus rectangle.
				_TextBrush = new SolidBrush(Color.White);
				g.FillRectangle(Brushes.Black, e.Bounds);
			}
			else
			{
				_TextBrush = new System.Drawing.SolidBrush(Color.Black);
				e.DrawBackground();
			}

			// Use our own font. Because we CAN.
			Font _TabFont = new Font("Comic Sans Ms", 14, FontStyle.Bold, GraphicsUnit.Pixel);

			// Draw string. Center the text.
			StringFormat _StringFlags = new StringFormat();
			_StringFlags.Alignment = StringAlignment.Center;
			_StringFlags.LineAlignment = StringAlignment.Center;
			g.DrawString(_TabPage.Text, _TabFont, _TextBrush,
						 _TabBounds, new StringFormat(_StringFlags));
			}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Buy(0);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Buy(1);
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Buy(10);
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Buy(6);
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Buy(11);
		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}
		private int ConvertNameIntoNumbaNiggazYo(string name)
		{
			if (name == "Team Fortress 2") { return 0; }
			if (name == "Star Craft 2") { return 1; }
			if (name == "Half life 2") { return 2; }
			if (name == "Portal") { return 3; }
			if (name == "World of Warcraft") { return 4; }
			if (name == "Heroes 6") { return 5; }
			if (name == "Dark Sides 2") { return 6; }
			if (name == "Black Mesa") { return 7; }
			if (name == "Dota2") { return 8; }
			if (name == "Witcher") { return 9; }
			if (name == "Battle Field 3") { return 10; }
			if (name == "Diablo 3") { return 11; }
			return 0;
		}
		private void initializeTabPage3()
		{
		}
		private void initializeTabPage2()
		{
			pblist1.Add(pictureBox18);
			pblist1.Add(pictureBox19);
			pblist1.Add(pictureBox20);
			pblist1.Add(pictureBox21);
			pblist1.Add(pictureBox22);
			pblist1.Add(pictureBox23);
			pblist1.Add(pictureBox24);
			pblist1.Add(pictureBox25);
			pblist1.Add(pictureBox26);
			pblist1.Add(pictureBox27);
			pblist1.Add(pictureBox28);
			pblist1.Add(pictureBox29);
			llist.Add(label3);
			llist.Add(label4);
			llist.Add(label5);
			llist.Add(label6);
			llist.Add(label7);
			llist.Add(label8);
			llist.Add(label9);
			llist.Add(label10);
			llist.Add(label11);
			llist.Add(label12);
			llist.Add(label13);
			llist.Add(label14);
			int k = 0;
			int u = 0;
			for (int i = 0; i < 12; i++)
			{
				llist[i].Visible = false;
				pblist1[i].Visible = false;
				pblist1[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				llist[i].Location = new Point(10+u*300, 75+150*k);
				k++;
				if (i == 3) { k = 0; }
				if (i == 7) { k = 0; }
				if (i >= 3) { u = 1; }
				if (i >= 7) { u = 2; }
			}
			int iii = 0;
			if( user.Glib.size() - 2 >= 0)
			{
				iii = user.Glib.size() - 2;
			}
			for (int i = 0 ; i < user.Glib.size(); i++)
			{
				string path = "..\\..\\pictures\\page2\\";
				llist[i].Visible = true;
				pblist1[i].Visible = true;
				pblist1[i].BringToFront();
				pblist1[i].Size = new System.Drawing.Size(150, 150); 
				llist[i].Text = user.Glib.getByIndex(i).Name;
				string src = path + user.Glib.getByIndex(i).Name + ".jpg";
				Image image = Image.FromFile(src);
				pblist1[i].Image = image;
				pblist1[i].Name = user.Glib.getByIndex(i).Name;
				pblist1[i].DoubleClick += new System.EventHandler(this.BoughtPictures_Click);
			}
		}

		private void label16_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void label15_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void label16_MouseEnter(object sender, EventArgs e)
		{
			label16.ForeColor = Color.AliceBlue;
		}

		private void label15_DragEnter(object sender, DragEventArgs e)
		{

		}

		private void label16_MouseLeave(object sender, EventArgs e)
		{
			label16.ForeColor = Color.DarkGray;
		}

		private void label15_MouseLeave(object sender, EventArgs e)
		{
			label15.ForeColor = Color.DarkGray;
		}

		private void label15_MouseEnter(object sender, EventArgs e)
		{
			label15.ForeColor = Color.AliceBlue;
		}

		private void tabPage2_Enter(object sender, EventArgs e)
		{
			for (int i = 0; i < 12; i++)
			{
				int k = i;
				if (k > 3) { k = k - 4; }
				if (k > 3) { k = k - 4; }
				pblist1[i].Location = new Point(-150, 3 + 156 * k);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label2_Click(sender, e);
		}

		private void label18_Click(object sender, EventArgs e)
		{
			Label temp = new Label();
			this.tabPage3.Controls.Add(temp);
			temp.Text = "new game";
			
			temp.Location = new Point(4, newgameList.Count * 25 + 75);
			newgameList.Add(temp);
			attachEvent(newgameList.Count-1);
		}
		private void attachEvent(int i)
		{
			newgameList[i].DoubleClick+=new EventHandler(newGame1Click);
		}
		private void newGame1Click(object sender, EventArgs e)
		{
			IndieGame igame = new IndieGame();
			igame.run();
		}
	}
}
