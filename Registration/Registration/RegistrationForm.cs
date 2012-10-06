using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace Registration
{
	public partial class RegistrationForm : Form
	{
		protected RegistrationControl rcntrl;
		private bool Move;
		private int X;
		private int Y;
        //Bitmap Captcha;
        private bool repaintCaptcha = true;

		public RegistrationForm(RegistrationControl _rcntrl)
		{
			rcntrl = _rcntrl;
			InitializeComponent();
			button1.ForeColor = Color.DarkGray;
			button2.ForeColor = Color.DarkGray;
		}

		private void RegistrationForm_Load(object sender, EventArgs e)
		{
			button3.TabStop = false;
			button4.TabStop = false;
			CancelButton = button3;
			AcceptButton = button4;
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//мало би бути в контролі,правда віталік? але я не маю токлвої перевірки потім перенесу))
			if (rcntrl.validateTextBox1(textBox1.Text)=="OK")
			{
				label1.Text = "Acceptable";
				label1.ForeColor = Color.GreenYellow;
				if (rcntrl.registerComplete(label1.Text, label2.Text, label4.Text, label5.Text))
				{
					button1.Visible = true;
				}
			}
			else
			{
				if (rcntrl.validateTextBox1(textBox1.Text) == "Email needs @")
				{
					label1.Text = "Wrong email format";
					label1.ForeColor = Color.FromArgb(180, 0, 0); ;
					button1.Visible = false;
				}
				else
				{
					label1.Text = "Already Registered";
					label1.ForeColor = Color.FromArgb(180, 0, 0); ;
					button1.Visible = false;
				}
			}
		}
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if (rcntrl.validateTextBox2(textBox2.Text, textBox3.Text))
			{
				label2.Text = "Acceptable";
				label2.ForeColor = Color.GreenYellow;
				label3.Hide();
				if (rcntrl.registerComplete(label1.Text, label2.Text, label4.Text, label5.Text))
				{
					button1.Visible = true;
				}
			}
			else
			{
				label2.Text = "passwords does not match";
				label2.ForeColor = Color.FromArgb(180, 0, 0); ;
				button1.Visible = false;
			}

		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			if (rcntrl.validateTextBox2(textBox2.Text,textBox3.Text))
			{
				label2.Text = "Acceptable";
				label2.ForeColor = Color.GreenYellow;
				label3.Hide();
				if (rcntrl.registerComplete(label1.Text, label2.Text, label4.Text, label5.Text))
				{
					button1.Visible = true;
				}
			}
			else
			{
				label2.Text = "does not match";
				label2.ForeColor = Color.FromArgb(180, 0, 0); ;
				label3.Text = "does not match";
				label3.ForeColor = Color.FromArgb(180, 0, 0); ;
				button1.Visible = false;

			}
		}
		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			if(rcntrl.validateComboBox1(comboBox1.Text))
			{
				label4.Text = "Unacceptable";
				label4.ForeColor = Color.FromArgb(180, 0, 0); ;
				button1.Visible = false;
			}
			else 
			{
				label4.Text = "Acceptable";
				label4.ForeColor = Color.GreenYellow;
				if (rcntrl.registerComplete(label1.Text, label2.Text, label4.Text, label5.Text))
				{
					button1.Visible = true;
				}
			}
		}
		private void comboBox2_TextChanged(object sender, EventArgs e)
		{
			if (rcntrl.validatecomboBox2(comboBox2.Text))
			{
				label5.Text = "Acceptable";
				label5.ForeColor = Color.GreenYellow;
				if (rcntrl.registerComplete(label1.Text, label2.Text, label4.Text, label5.Text))
				{
					button1.Visible = true;
				}
			}
			else
			{
				if (comboBox2.Text != "")
				{
					label5.Text = "Too young,baby";
					label5.ForeColor = Color.FromArgb(180, 0, 0); 
					button1.Visible = false;

				}
			}

		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (button1.Visible == true)
			{
				if (rcntrl.checkCaptcha(textBox4.Text))
				{
					rcntrl.createPerson(textBox1.Text, rcntrl.ComputeStringMD5Hash(textBox2.Text), comboBox1.Text, comboBox2.Text);
					this.DialogResult = DialogResult.OK;
				}
				else
				{
					repaintCaptcha = true;
					this.Invalidate();
				}
			}
            
		}
		private void button1_Hover(object sender, EventArgs e)
		{
			if (button1.Visible)
			{
				button1.ForeColor = Color.AliceBlue;
			}
		}
		private void button1_outHover(object sender, EventArgs e)
		{
			if (button1.Visible)
			{
				button1.ForeColor = Color.DarkGray;
			}
		}
		private void button2_Hover(object sender, EventArgs e)
		{
				button2.ForeColor = Color.AliceBlue;
		}
		private void button2_outHover(object sender, EventArgs e)
		{
				button2.ForeColor = Color.DarkGray;
		}
		private void button2_Click_1(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
		{
			Move = true;
			X = e.X;
			Y = e.Y;
		}

		private void RegistrationForm_MouseUp(object sender, MouseEventArgs e)
		{
			Move = false;
		}

		private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (Move)
			{
				this.SetDesktopLocation(MousePosition.X - X,MousePosition.Y - Y);
			}
		}

        private void RegistrationForm_Shown(object sender, EventArgs e)
        {
            //repaintCaptcha = false;
        }

        private void RegistrationForm_Paint(object sender, PaintEventArgs e)
        {
            if (repaintCaptcha)
            {
				Bitmap Captcha;
                Captcha = rcntrl.createImage(120, 56);
                repaintCaptcha = false;
				pictureBox2.Image = Captcha;
            }
            //Graphics graphicsObj = e.Graphics;
            //graphicsObj.DrawImage(Captcha, 22, 215, Captcha.Width, Captcha.Height);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            repaintCaptcha = true;
            this.Invalidate();
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

		private void button3_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			button1_Click_1(sender, e);
		}

		private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
		{
			comboBox1_TextChanged(sender, e);
		}
	}
}
