using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registration
{
	public partial class UserIndieGame : Form
	{
		private Person user;
		private Indie game;
		public UserIndieGame()
		{
			InitializeComponent();
		}

		private void UserIndieGame_Load(object sender, EventArgs e)
		{

		}

		public DialogResult run()
		{
			return this.ShowDialog();
		}
		public Person getUser()
		{
			return user;
		}
		public DialogResult run(Indie _game,Person _user)
		{
			game = _game;
			label1.Text = game.Name;
			richTextBox1.Text = game.Description;
			pictureBox1.ImageLocation = game.Path;
			user = _user;

			for (int i = 0; i < user.IGlib.Count; i++)
			{
				if (user.IGlib[i].Name == game.Name)
				{
					label3.Enabled = false;
					label3.Text = "Play";
				}
			}

				return this.ShowDialog();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			user.IGlib.Add(game);
			this.DialogResult=DialogResult.OK;
		}
	}
}
