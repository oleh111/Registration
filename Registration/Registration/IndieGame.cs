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
		private void IndieGame_Load(object sender, EventArgs e)
		{

		}
	}
}
