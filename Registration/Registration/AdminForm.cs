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
	public partial class AdminForm : Form
	{
		private AdminFormController afcontr;
		protected Library libr;
		private  int Times;
		public AdminForm(Library _libr)
		{
			libr = _libr;
			afcontr = new AdminFormController();
			InitializeComponent();
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			Times = 0;
			this.login.Width = (int)(SystemInformation.PrimaryMonitorSize.Width * 0.35);
			this.country.Width = (int)(SystemInformation.PrimaryMonitorSize.Width * 0.3);
			this.birth.Width = (int)(SystemInformation.PrimaryMonitorSize.Width * 0.2);
			this.secure.Width = (int)(SystemInformation.PrimaryMonitorSize.Width * 0.3);
			this.label16.Location = new System.Drawing.Point((SystemInformation.PrimaryMonitorSize.Width - 20), 10);
			this.label15.Location = new System.Drawing.Point((SystemInformation.PrimaryMonitorSize.Width - 40), 10);
			this.ok.Location = new System.Drawing.Point((SystemInformation.PrimaryMonitorSize.Width - 80), 10);
			this.dataGridView1.Size = new System.Drawing.Size(SystemInformation.PrimaryMonitorSize.Width, (int)(SystemInformation.PrimaryMonitorSize.Height * 0.7216));
			this.dataGridView1.Location = new System.Drawing.Point(0, (int)(SystemInformation.PrimaryMonitorSize.Height * 0.20703));
			Refresh();
		}

		private void label16_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void label15_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		public void Refresh()
		{
			dataGridView1.Rows.Clear();
			if (libr.Bracket.Count > 0)
			{
				dataGridView1.Rows.Add(libr.Bracket.Count);
			}
			for (int i = 0; i < libr.Bracket.Count; i++)
			{
				dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(libr.Bracket[i].Login);
				dataGridView1.Rows[i].Cells[2].Value = libr.Bracket[i].Country;
				dataGridView1.Rows[i].Cells[1].Value = libr.Bracket[i].Age;
				dataGridView1.Rows[i].Cells[3].Value = Convert.ToString(libr.Bracket[i].Security);
			}
		}
		private void CellChanged(object sender, EventArgs e)
		{
			Times++;
			if (Times > libr.Bracket.Count * 4)
			{
				MessageBox.Show(Times.ToString());
				for (int i = 0; i < libr.Bracket.Count; i++)
				{
					libr.Bracket[i].Login = dataGridView1.Rows[i].Cells[0].Value.ToString();
					libr.Bracket[i].Country = dataGridView1.Rows[i].Cells[2].Value.ToString();
					libr.Bracket[i].Age=dataGridView1.Rows[i].Cells[1].Value.ToString();
					libr.Bracket[i].Security = dataGridView1.Rows[i].Cells[3].Value.ToString(); 
				}
			}
		}
		public Library getLib()
		{
			return libr;
		}
		private void ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
