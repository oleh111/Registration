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
	public partial class PaymentForm : Form
	{
	public PaymentForm()
        {
            InitializeComponent();
        }

        private void CardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CVVTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CardNumberTextBox_Enter(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }

        private void CardNumberTextBox_Leave(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void DateMonthComboBox_Enter(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }

        private void DateMonthComboBox_Leave(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void DateYearComboBox_Enter(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }

        private void DateYearComboBox_Leave(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void CVVTextBox_Enter(object sender, EventArgs e)
        {
            pictureBox3.Show();
        }

        private void CVVTextBox_Leave(object sender, EventArgs e)
        {
            pictureBox3.Hide();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKLabel_Click(object sender, EventArgs e)
        {
            if (CardNumberTextBox.Text.Length == 16 && DateMonthComboBox.Text.Length > 0 && DateYearComboBox.Text.Length >= 4 && CVVTextBox.Text.Length == 3)
            {
                Card c = new Card();
                c.setNumber(CardNumberTextBox.Text);
                c.setDate(DateMonthComboBox.Text, DateYearComboBox.Text);
                c.setCVV(CVVTextBox.Text);

				this.DialogResult = DialogResult.OK;
            }
            else
            {
                label5.Show();
            }
        }

        private void CancelLabel_MouseLeave(object sender, EventArgs e)
        {
			CancelLabel.Font = new System.Drawing.Font("Segoe Script", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

        private void CancelLabel_MouseEnter(object sender, EventArgs e)
        {
			CancelLabel.Font = new System.Drawing.Font("Segoe Script", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

        private void OKLabel_MouseEnter(object sender, EventArgs e)
        {
            OKLabel.Font = new System.Drawing.Font("Segoe Script", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

        private void OKLabel_MouseLeave(object sender, EventArgs e)
        {
			OKLabel.Font = new System.Drawing.Font("Segoe Script", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

		private void PaymentForm_Load(object sender, EventArgs e)
		{

		}

        //private void PaymentForm_MouseEnter(object sender, EventArgs e)
        //{
        //    //if (CardNumberTextBox.Text.Length == 16 && DateMonthComboBox.Text.Length > 0 && DateYearComboBox.Text.Length >= 4 && CVVTextBox.Text.Length == 3)
        //    //{
        //    //    label5.Hide();
        //    //    OKLabel.Show();
        //    //}
        //    //else
        //    //{
        //    //    label5.Show();
        //    //    OKLabel.Hide();
        //    //}
        //}
    }
}
