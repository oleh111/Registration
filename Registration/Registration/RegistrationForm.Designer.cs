namespace Registration
{
	partial class RegistrationForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.textBox1.Location = new System.Drawing.Point(21, 49);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(187, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.textBox2.Location = new System.Drawing.Point(21, 79);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(187, 22);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.textBox3.Location = new System.Drawing.Point(21, 110);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(187, 22);
			this.textBox3.TabIndex = 2;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Ukraine",
            "Russia",
            "USA",
            "Poland",
            "Bulgary",
            "Greece",
            "Canada",
            "Japan",
            "China",
            "Other"});
			this.comboBox1.Location = new System.Drawing.Point(21, 139);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(188, 24);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(217, 49);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 29);
			this.label1.TabIndex = 7;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(217, 79);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 29);
			this.label2.TabIndex = 8;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(217, 110);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(177, 29);
			this.label3.TabIndex = 9;
			this.label3.Text = "Repeat Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(217, 139);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 29);
			this.label4.TabIndex = 10;
			this.label4.Text = "Country";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(217, 171);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 29);
			this.label5.TabIndex = 11;
			this.label5.Text = "Year of Birth";
			// 
			// comboBox2
			// 
			this.comboBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985"});
			this.comboBox2.Location = new System.Drawing.Point(21, 171);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(188, 24);
			this.comboBox2.TabIndex = 12;
			this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.button2.Location = new System.Drawing.Point(336, 345);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 29);
			this.button2.TabIndex = 13;
			this.button2.Text = "Cancel";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			this.button2.MouseEnter += new System.EventHandler(this.button2_Hover);
			this.button2.MouseLeave += new System.EventHandler(this.button2_outHover);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.button1.Location = new System.Drawing.Point(261, 345);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(62, 29);
			this.button1.TabIndex = 14;
			this.button1.Text = "Okay";
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			this.button1.MouseEnter += new System.EventHandler(this.button1_Hover);
			this.button1.MouseLeave += new System.EventHandler(this.button1_outHover);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.DarkGray;
			this.label6.Location = new System.Drawing.Point(379, -6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 29);
			this.label6.TabIndex = 15;
			this.label6.Text = "x";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
			this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.DarkGray;
			this.label7.Location = new System.Drawing.Point(336, -6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 29);
			this.label7.TabIndex = 16;
			this.label7.Text = "_";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			this.label7.MouseEnter += new System.EventHandler(this.label7_MouseEnter);
			this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::Registration.Properties.Resources._11954451921942476621jean_victor_balin_refresh_svg_hi;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(160, 219);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(49, 56);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.textBox4.Location = new System.Drawing.Point(21, 329);
			this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(187, 22);
			this.textBox4.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(217, 277);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(138, 29);
			this.label8.TabIndex = 19;
			this.label8.Text = "Wrong  code";
			this.label8.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Location = new System.Drawing.Point(21, 219);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(120, 56);
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.BackgroundImage = global::Registration.Properties.Resources.register_bg2;
			this.ClientSize = new System.Drawing.Size(421, 396);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "RegistrationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegistrationForm";
			this.Load += new System.EventHandler(this.RegistrationForm_Load);
			this.Shown += new System.EventHandler(this.RegistrationForm_Shown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.RegistrationForm_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label button2;
		private System.Windows.Forms.Label button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}