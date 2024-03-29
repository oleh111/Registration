﻿using System;
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
	partial class PaymentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DateMonthComboBox = new System.Windows.Forms.ComboBox();
			this.DateYearComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.CardNumberTextBox = new System.Windows.Forms.TextBox();
			this.CVVTextBox = new System.Windows.Forms.TextBox();
			this.OKLabel = new System.Windows.Forms.Label();
			this.CancelLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(16, 108);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Card number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(16, 164);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 33);
			this.label2.TabIndex = 2;
			this.label2.Text = "Expire date (MM/YY)";
			// 
			// DateMonthComboBox
			// 
			this.DateMonthComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.DateMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DateMonthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DateMonthComboBox.FormattingEnabled = true;
			this.DateMonthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.DateMonthComboBox.Location = new System.Drawing.Point(308, 164);
			this.DateMonthComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.DateMonthComboBox.Name = "DateMonthComboBox";
			this.DateMonthComboBox.Size = new System.Drawing.Size(59, 24);
			this.DateMonthComboBox.TabIndex = 3;
			this.DateMonthComboBox.Enter += new System.EventHandler(this.DateMonthComboBox_Enter);
			this.DateMonthComboBox.Leave += new System.EventHandler(this.DateMonthComboBox_Leave);
			// 
			// DateYearComboBox
			// 
			this.DateYearComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.DateYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DateYearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DateYearComboBox.FormattingEnabled = true;
			this.DateYearComboBox.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
			this.DateYearComboBox.Location = new System.Drawing.Point(400, 164);
			this.DateYearComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.DateYearComboBox.Name = "DateYearComboBox";
			this.DateYearComboBox.Size = new System.Drawing.Size(81, 24);
			this.DateYearComboBox.TabIndex = 4;
			this.DateYearComboBox.Enter += new System.EventHandler(this.DateYearComboBox_Enter);
			this.DateYearComboBox.Leave += new System.EventHandler(this.DateYearComboBox_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(376, 167);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "/";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(16, 213);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 33);
			this.label4.TabIndex = 6;
			this.label4.Text = "Security code";
			// 
			// CardNumberTextBox
			// 
			this.CardNumberTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.CardNumberTextBox.Location = new System.Drawing.Point(308, 108);
			this.CardNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CardNumberTextBox.MaxLength = 16;
			this.CardNumberTextBox.Name = "CardNumberTextBox";
			this.CardNumberTextBox.Size = new System.Drawing.Size(217, 22);
			this.CardNumberTextBox.TabIndex = 1;
			this.CardNumberTextBox.Enter += new System.EventHandler(this.CardNumberTextBox_Enter);
			this.CardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberTextBox_KeyPress);
			this.CardNumberTextBox.Leave += new System.EventHandler(this.CardNumberTextBox_Leave);
			// 
			// CVVTextBox
			// 
			this.CVVTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.CVVTextBox.Location = new System.Drawing.Point(308, 213);
			this.CVVTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CVVTextBox.MaxLength = 3;
			this.CVVTextBox.Name = "CVVTextBox";
			this.CVVTextBox.Size = new System.Drawing.Size(99, 22);
			this.CVVTextBox.TabIndex = 5;
			this.CVVTextBox.Enter += new System.EventHandler(this.CVVTextBox_Enter);
			this.CVVTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CVVTextBox_KeyPress);
			this.CVVTextBox.Leave += new System.EventHandler(this.CVVTextBox_Leave);
			// 
			// OKLabel
			// 
			this.OKLabel.AutoSize = true;
			this.OKLabel.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OKLabel.Location = new System.Drawing.Point(308, 335);
			this.OKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.OKLabel.Name = "OKLabel";
			this.OKLabel.Size = new System.Drawing.Size(56, 40);
			this.OKLabel.TabIndex = 14;
			this.OKLabel.Text = "OK";
			this.OKLabel.Click += new System.EventHandler(this.OKLabel_Click);
			this.OKLabel.MouseEnter += new System.EventHandler(this.OKLabel_MouseEnter);
			this.OKLabel.MouseLeave += new System.EventHandler(this.OKLabel_MouseLeave);
			// 
			// CancelLabel
			// 
			this.CancelLabel.AutoSize = true;
			this.CancelLabel.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CancelLabel.Location = new System.Drawing.Point(473, 335);
			this.CancelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CancelLabel.Name = "CancelLabel";
			this.CancelLabel.Size = new System.Drawing.Size(102, 40);
			this.CancelLabel.TabIndex = 15;
			this.CancelLabel.Text = "Cancel";
			this.CancelLabel.Click += new System.EventHandler(this.CancelLabel_Click);
			this.CancelLabel.MouseEnter += new System.EventHandler(this.CancelLabel_MouseEnter);
			this.CancelLabel.MouseLeave += new System.EventHandler(this.CancelLabel_MouseLeave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.DarkRed;
			this.label5.Location = new System.Drawing.Point(304, 283);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 17);
			this.label5.TabIndex = 16;
			this.label5.Text = "Enter all data!!!";
			this.label5.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(583, 79);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(332, 187);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(583, 79);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(332, 187);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(583, 79);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(332, 187);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1000, 1000);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1000, 1000);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// PaymentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(925, 405);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CancelLabel);
			this.Controls.Add(this.OKLabel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.CVVTextBox);
			this.Controls.Add(this.CardNumberTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.DateYearComboBox);
			this.Controls.Add(this.DateMonthComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "PaymentForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Payment";
			this.Load += new System.EventHandler(this.PaymentForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox DateMonthComboBox;
		private System.Windows.Forms.ComboBox DateYearComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox CardNumberTextBox;
		private System.Windows.Forms.TextBox CVVTextBox;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label OKLabel;
		private System.Windows.Forms.Label CancelLabel;
		private System.Windows.Forms.Label label5;
		private Button button1;
		private Button button2;
	}
}