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
	partial class AdminForm
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
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.ok = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.secure = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.ForeColor = System.Drawing.Color.DarkGray;
			this.label16.Location = new System.Drawing.Point(656, 115);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(20, 24);
			this.label16.TabIndex = 14;
			this.label16.Text = "x";
			this.label16.Click += new System.EventHandler(this.label16_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.ForeColor = System.Drawing.Color.DarkGray;
			this.label15.Location = new System.Drawing.Point(630, 115);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(20, 24);
			this.label15.TabIndex = 15;
			this.label15.Text = "_";
			this.label15.Click += new System.EventHandler(this.label15_Click);
			//
			//
			//
			this.ok.AutoSize = true;
			this.ok.BackColor = System.Drawing.Color.Transparent;
			this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ok.ForeColor = System.Drawing.Color.DarkGray;
			this.ok.Location = new System.Drawing.Point(656, 115);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(20, 24);
			this.ok.TabIndex = 14;
			this.ok.Text = "OK";
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.BackgroundColor = Color.FromArgb(10,10,10);
			this.dataGridView1.ForeColor = Color.DarkGreen;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.login,
            this.country,
            this.birth,
            this.secure});
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.TabIndex = 16;
			foreach (DataGridViewColumn column in dataGridView1.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(CellChanged);
			// 
			// id
			// 
			this.login.HeaderText = "Login";
			this.login.Name = "Login";
			this.login.ReadOnly = true;
	        // 
			// Title
			// 
			this.country.HeaderText = "Birth year";
			this.country.Name = "Birth year";
			this.country.ReadOnly = true;
			// 
			// Author
			// 
			this.birth.HeaderText = "Country";
			this.birth.Name = "Country";
			this.birth.ReadOnly = true;
			// 
			// Year
			// 
			this.secure.HeaderText = "Secure level";
			this.secure.Name = "Secure level";
			this.secure.ReadOnly = false;

			// 
			// AdminForm
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.BackgroundImage = global::Registration.Properties.Resources.shp_bg;
			this.ClientSize = new System.Drawing.Size(SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.ok);
			this.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "AdminForm";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label16;
		private Label label15;
		private Label ok;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn login;
		private DataGridViewTextBoxColumn country;
		private DataGridViewTextBoxColumn birth;
		private DataGridViewTextBoxColumn secure;
	}
}