using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing.Drawing2D;
namespace Registration
{
	partial class ShopForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.movingBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.movingBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(1018, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(1087, 74);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Log Out";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 62);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(308, 315);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(308, 62);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(308, 315);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(616, 62);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(308, 315);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(924, 62);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(308, 315);
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(1232, 62);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(308, 315);
			this.pictureBox5.TabIndex = 9;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Location = new System.Drawing.Point(0, 0);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(133, 62);
			this.pictureBox6.TabIndex = 11;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Location = new System.Drawing.Point(0, 0);
			this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(133, 62);
			this.pictureBox7.TabIndex = 10;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Location = new System.Drawing.Point(0, 0);
			this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(133, 62);
			this.pictureBox8.TabIndex = 9;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Location = new System.Drawing.Point(0, 0);
			this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(133, 62);
			this.pictureBox9.TabIndex = 8;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Location = new System.Drawing.Point(0, 0);
			this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(133, 62);
			this.pictureBox10.TabIndex = 7;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Location = new System.Drawing.Point(0, 0);
			this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(133, 62);
			this.pictureBox11.TabIndex = 6;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Location = new System.Drawing.Point(0, 0);
			this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(133, 62);
			this.pictureBox12.TabIndex = 5;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Location = new System.Drawing.Point(0, 0);
			this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(133, 62);
			this.pictureBox13.TabIndex = 4;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Location = new System.Drawing.Point(0, 0);
			this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(133, 62);
			this.pictureBox14.TabIndex = 3;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Location = new System.Drawing.Point(0, 0);
			this.pictureBox15.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(133, 62);
			this.pictureBox15.TabIndex = 2;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Location = new System.Drawing.Point(0, 0);
			this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(133, 62);
			this.pictureBox16.TabIndex = 1;
			this.pictureBox16.TabStop = false;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Location = new System.Drawing.Point(0, 0);
			this.pictureBox17.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(133, 62);
			this.pictureBox17.TabIndex = 0;
			this.pictureBox17.TabStop = false;
			// 
			// movingBox1
			// 
			this.movingBox1.Location = new System.Drawing.Point(0, 0);
			this.movingBox1.Name = "movingBox1";
			this.movingBox1.Size = new System.Drawing.Size(100, 50);
			this.movingBox1.TabIndex = 0;
			this.movingBox1.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tabControl1.ItemSize = new System.Drawing.Size(462, 18);
			this.tabControl1.Location = new System.Drawing.Point(162, 211);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(397, 273);
			this.tabControl1.TabIndex = 12;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.MenuText;
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.pictureBox2);
			this.tabPage1.Controls.Add(this.pictureBox3);
			this.tabPage1.Controls.Add(this.pictureBox4);
			this.tabPage1.Controls.Add(this.pictureBox5);
			this.tabPage1.Controls.Add(this.pictureBox6);
			this.tabPage1.Controls.Add(this.pictureBox7);
			this.tabPage1.Controls.Add(this.pictureBox8);
			this.tabPage1.Controls.Add(this.pictureBox9);
			this.tabPage1.Controls.Add(this.pictureBox10);
			this.tabPage1.Controls.Add(this.pictureBox11);
			this.tabPage1.Controls.Add(this.pictureBox12);
			this.tabPage1.Controls.Add(this.pictureBox13);
			this.tabPage1.Controls.Add(this.pictureBox14);
			this.tabPage1.Controls.Add(this.pictureBox15);
			this.tabPage1.Controls.Add(this.pictureBox16);
			this.tabPage1.Controls.Add(this.pictureBox17);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(389, 247);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Steamie Shop";
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.MenuText;
			this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.pictureBox29);
			this.tabPage2.Controls.Add(this.pictureBox28);
			this.tabPage2.Controls.Add(this.pictureBox27);
			this.tabPage2.Controls.Add(this.pictureBox26);
			this.tabPage2.Controls.Add(this.pictureBox25);
			this.tabPage2.Controls.Add(this.pictureBox24);
			this.tabPage2.Controls.Add(this.pictureBox23);
			this.tabPage2.Controls.Add(this.pictureBox22);
			this.tabPage2.Controls.Add(this.pictureBox21);
			this.tabPage2.Controls.Add(this.pictureBox20);
			this.tabPage2.Controls.Add(this.pictureBox19);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.pictureBox18);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(389, 247);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "My Library";
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(787, 661);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(48, 13);
			this.label14.TabIndex = 23;
			this.label14.Text = "label14";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(787, 465);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 13);
			this.label13.TabIndex = 22;
			this.label13.Text = "label13";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(787, 270);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 13);
			this.label12.TabIndex = 21;
			this.label12.Text = "label12";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(787, 80);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = "label11";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(415, 661);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "label10";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(415, 465);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "label9";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(415, 270);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "label8";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(415, 80);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "label7";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(61, 661);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "label6";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(61, 465);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "label5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 270);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "label4";
			// 
			// pictureBox29
			// 
			this.pictureBox29.Location = new System.Drawing.Point(967, 583);
			this.pictureBox29.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(200, 185);
			this.pictureBox29.TabIndex = 12;
			this.pictureBox29.TabStop = false;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Location = new System.Drawing.Point(967, 391);
			this.pictureBox28.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(200, 185);
			this.pictureBox28.TabIndex = 11;
			this.pictureBox28.TabStop = false;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Location = new System.Drawing.Point(967, 199);
			this.pictureBox27.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(200, 185);
			this.pictureBox27.TabIndex = 10;
			this.pictureBox27.TabStop = false;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Location = new System.Drawing.Point(967, 7);
			this.pictureBox26.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(200, 185);
			this.pictureBox26.TabIndex = 9;
			this.pictureBox26.TabStop = false;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Location = new System.Drawing.Point(555, 580);
			this.pictureBox25.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(200, 185);
			this.pictureBox25.TabIndex = 8;
			this.pictureBox25.TabStop = false;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Location = new System.Drawing.Point(555, 388);
			this.pictureBox24.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(200, 185);
			this.pictureBox24.TabIndex = 7;
			this.pictureBox24.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Location = new System.Drawing.Point(555, 196);
			this.pictureBox23.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(200, 185);
			this.pictureBox23.TabIndex = 6;
			this.pictureBox23.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Location = new System.Drawing.Point(555, 4);
			this.pictureBox22.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(200, 185);
			this.pictureBox22.TabIndex = 5;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Location = new System.Drawing.Point(184, 580);
			this.pictureBox21.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(200, 185);
			this.pictureBox21.TabIndex = 4;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Location = new System.Drawing.Point(184, 388);
			this.pictureBox20.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(200, 185);
			this.pictureBox20.TabIndex = 3;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Location = new System.Drawing.Point(184, 196);
			this.pictureBox19.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(200, 185);
			this.pictureBox19.TabIndex = 2;
			this.pictureBox19.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 80);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "label3";
			// 
			// pictureBox18
			// 
			this.pictureBox18.Location = new System.Drawing.Point(184, 4);
			this.pictureBox18.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(200, 185);
			this.pictureBox18.TabIndex = 0;
			this.pictureBox18.TabStop = false;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Black;
			this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabPage3.Controls.Add(this.label18);
			this.tabPage3.Controls.Add(this.label17);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(389, 247);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Indie games";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.DarkGreen;
			this.label18.Location = new System.Drawing.Point(8, 31);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(103, 28);
			this.label18.TabIndex = 1;
			this.label18.Text = "+Add game";
			this.label18.Click += new System.EventHandler(this.label18_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(4, 4);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(711, 23);
			this.label17.TabIndex = 0;
			this.label17.Text = "Indie game page. every game developer can deploy his own game up here";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.ForeColor = System.Drawing.Color.DarkGray;
			this.label15.Location = new System.Drawing.Point(1159, 11);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(20, 24);
			this.label15.TabIndex = 14;
			this.label15.Text = "_";
			this.label15.Click += new System.EventHandler(this.label15_Click);
			this.label15.DragEnter += new System.Windows.Forms.DragEventHandler(this.label15_DragEnter);
			this.label15.MouseEnter += new System.EventHandler(this.label15_MouseEnter);
			this.label15.MouseLeave += new System.EventHandler(this.label15_MouseLeave);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.ForeColor = System.Drawing.Color.DarkGray;
			this.label16.Location = new System.Drawing.Point(1191, 11);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(20, 24);
			this.label16.TabIndex = 13;
			this.label16.Text = "x";
			this.label16.Click += new System.EventHandler(this.label16_Click);
			this.label16.MouseEnter += new System.EventHandler(this.label16_MouseEnter);
			this.label16.MouseLeave += new System.EventHandler(this.label16_MouseLeave);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(2000, 2000);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ShopForm
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.BackgroundImage = global::Registration.Properties.Resources.shp_bg;
			this.ClientSize = new System.Drawing.Size(1280, 1024);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ShopForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ShopForm";
			this.Load += new System.EventHandler(this.ShopForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShopForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShopForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShopForm_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.movingBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox movingBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox29;
		private System.Windows.Forms.PictureBox pictureBox28;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button1;
		private TabPage tabPage3;
		private Label label17;
		private Label label18;
	}
}