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
	public partial class LogInForm : Form
	{
		protected MainControl cntrl;

		private bool Move;
		private int X;
		private int Y;

		public LogInForm(MainControl _cntrl)
		{
			InitializeComponent();
			cntrl = _cntrl;
			label1.ForeColor = Color.DarkGray;
			label4.ForeColor = Color.DarkGray;
			label5.ForeColor = Color.DarkGray;
			
		}

		public void reLogIn()
		{
			this.Show();
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void LogInForm_Load(object sender, EventArgs e)
		{
			button1.TabStop = false;
			button2.TabStop = false;
			CancelButton = button2;
			AcceptButton = button1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cntrl.register();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			if (cntrl.validate(textBox1.Text, cntrl.ComputeStringMD5Hash(textBox2.Text)))
			{
				this.Hide();
                //Loading load = new Loading();
                //load.ShowDialog(cntrl.getForm());
				cntrl.Shop(textBox1.Text,textBox2.Text);
			}
			else
			{
				MessageBox.Show("Your account is not valid,or doesn't exist");
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			cntrl.register();
			this.Show();
		}

		private void LogInForm_MouseDown(object sender, MouseEventArgs e)
		{
			Move = true;
			X = e.X;
			Y = e.Y;
		}

		private void LogInForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (Move)
			{
				this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
			}
		}

		private void LogInForm_MouseUp(object sender, MouseEventArgs e)
		{
			Move = false;
		}

		private void label1_MouseEnter(object sender, EventArgs e)
		{
			label1.ForeColor = Color.AliceBlue;
		}

		private void label1_MouseLeave(object sender, EventArgs e)
		{
			label1.ForeColor = Color.DarkGray;
		}

		private void label4_MouseLeave(object sender, EventArgs e)
		{
			label4.ForeColor = Color.DarkGray;
		}

		private void label4_MouseEnter(object sender, EventArgs e)
		{
			label4.ForeColor = Color.AliceBlue;
		}

		private void label5_MouseEnter(object sender, EventArgs e)
		{
			label5.ForeColor = Color.AliceBlue;
		}

		private void label5_MouseLeave(object sender, EventArgs e)
		{
			label5.ForeColor = Color.DarkGray;
		}

        private void label6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.AliceBlue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DarkGray;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.AliceBlue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.DarkGray;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{

		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{

		}

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

		private void button1_Click_1(object sender, EventArgs e)
		{
			label1_Click(this, EventArgs.Empty);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
