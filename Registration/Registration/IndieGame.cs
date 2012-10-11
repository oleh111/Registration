using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
			pictureBox1.ImageLocation = game.Path;
			pictureBox2.ImageLocation = game.Icon;
			return this.ShowDialog();
		}
		private void IndieGame_Load(object sender, EventArgs e)
		{
			this.pictureBox1.AllowDrop = true;
			this.pictureBox2.AllowDrop = true;

			// Add event handlers for the drag & drop functionality
			this.pictureBox1.DragEnter += new DragEventHandler(Form_DragEnter);
			this.pictureBox1.DragDrop += new DragEventHandler(Form_DragDrop);

			this.pictureBox2.DragEnter += new DragEventHandler(ico_DragEnter);
			this.pictureBox2.DragDrop += new DragEventHandler(ico_DragDrop);
		}

		void Form_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy; 
			else
				e.Effect = DragDropEffects.None; 

		}
		void Form_DragDrop(object sender, DragEventArgs e)
		{
			if (textBox1.Text != "")
			{
				string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
				string destiny = "..\\..\\Indie Games\\" + textBox1.Text + ".png";
				File.Copy(FileList[0], destiny, true);
				this.pictureBox1.ImageLocation = destiny;
				
			}
			else
			{
				MessageBox.Show("please make sure,you have entered game name");
			}
		}
		void ico_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;

		}
		void ico_DragDrop(object sender, DragEventArgs e)
		{
			if (textBox1.Text != "")
			{
				string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
				string destiny = "..\\..\\Indie Games\\" + textBox1.Text + ".gif";
				File.Copy(FileList[0], destiny, true);
				this.pictureBox2.ImageLocation = destiny;

			}
			else
			{
				MessageBox.Show("please make sure,you have entered game name");
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.DialogResult=DialogResult.OK;
		}
	}
}
