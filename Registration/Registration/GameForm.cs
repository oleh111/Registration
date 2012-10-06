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
	public partial class GameForm : Form
	{
		private string src1;
		private string src2;
		private string text1;
		GameFormController gfcntrl;
		Person user;

		public GameForm(GameFormController _gfcntrl)
		{
			src1 = "";
			src2 = "";
			text1 = "";
			gfcntrl =_gfcntrl;
			InitializeComponent();
		}
		public GameForm(Game game,Person _user,string t1,string t2,string t3)
		{
			user=_user;
			InitializeComponent();
			button1.ForeColor = Color.DarkGray;
			button2.ForeColor = Color.DarkGray;
			gfcntrl=new GameFormController();
			src1 = t3;
			src2 = t1;
			text1 = t2;

			Image image = Image.FromFile(src2);
			pictureBox1.Image = image;
			image = Image.FromFile(src1);
			pictureBox2.Image = image;
			label1.Text = text1;
			if (user.Glib.find(game.Name))
			{
				button1.Text = "Play";
				button1.Enabled = false;
			}
		}

		private void GameForm_Load(object sender, EventArgs e)
		{
			button3.TabStop = false;
			button4.TabStop = false;
			AcceptButton = button3;
			CancelButton = button4;
		}


		private void button1_Click_1(object sender, EventArgs e)
		{
			if (button1.Enabled == true)
			{
				PaymentForm pform = new PaymentForm();
				pform.ShowDialog();
				if (pform.DialogResult == DialogResult.OK)
				{
					this.DialogResult = DialogResult.OK;
				}
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void button1_MouseEnter(object sender, EventArgs e)
		{
			button1.ForeColor = Color.White;
		}

		private void button1_MouseLeave(object sender, EventArgs e)
		{
			button1.ForeColor = Color.DarkGray;
		}

		private void button2_MouseEnter(object sender, EventArgs e)
		{
			button2.ForeColor = Color.White;
		}

		private void button2_MouseLeave(object sender, EventArgs e)
		{
			button2.ForeColor = Color.DarkGray;
		}

		private void label6_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void label7_MouseEnter(object sender, EventArgs e)
		{
			label7.ForeColor = Color.AliceBlue;
		}

		private void label7_MouseLeave(object sender, EventArgs e)
		{
			label7.ForeColor = Color.DarkGray;
		}

		private void label6_DragEnter(object sender, DragEventArgs e)
		{
			label6.ForeColor = Color.AliceBlue;
		}

		private void label6_DragLeave(object sender, EventArgs e)
		{
			label6.ForeColor = Color.DarkGray;
		}

		private void label6_MouseEnter(object sender, EventArgs e)
		{
			label6.ForeColor = Color.AliceBlue;
		}

		private void label6_MouseLeave(object sender, EventArgs e)
		{
			label6.ForeColor = Color.DarkGray;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			button1_Click_1(sender, e);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			button2_Click_1(sender, e);
		}
	}
}
