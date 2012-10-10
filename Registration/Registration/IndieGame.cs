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
	public partial class IndieGame : Form
	{
		public IndieGame()
		{
			InitializeComponent();
		}

		public DialogResult run()
		{
			return this.ShowDialog();
		}
		public DialogResult run(Indie game)
		{
			textBox1.Text = game.Name;
			richTextBox1.Text = game.Description;
			return this.ShowDialog();
		}
		private void IndieGame_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.DialogResult=DialogResult.OK;
		}
	}
}
