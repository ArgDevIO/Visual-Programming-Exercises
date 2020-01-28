using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormValidationExample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void tbAge_Validating(object sender, CancelEventArgs e)
		{
			string errorMsg;
			int age;

			if (!int.TryParse(tbAge.Text, out age) || age < 1)
			{
				// Set the error message
				errorMsg = "Invalid age";
				// Cancel the event and select the text to be corrected by the user.
				e.Cancel = true;
				tbAge.Select(0, tbAge.Text.Length);
				// Set the ErrorProvider error with the text to display
				errorProviderAge.SetError(tbAge, errorMsg);
			}
			else
				errorProviderAge.SetError(tbAge, "");
		}

		private void tbEmail_Validating(object sender, CancelEventArgs e)
		{
			string errorMsg;
			if (!ValidEmailAddress(tbEmail.Text, out errorMsg))
			{
				// Cancel the event
				e.Cancel = true;
				errorProviderEmail.SetError(tbEmail, errorMsg);
			}
			else
				errorProviderEmail.SetError(tbEmail, "");
		}

		public bool ValidEmailAddress(string emailAddress, out string errorMsg)
		{
			// Confirm that the e-mail address string is not empty
			if (emailAddress.Length == 0)
			{
				errorMsg = "e-mail address is required!";
				return false;
			}

			// Confirm that there is an "@" and a "." in the e-mail address,
			// and in the correct order
			int atpos;
			if ((atpos = emailAddress.IndexOf("@")) > -1)
			{
				if (emailAddress.IndexOf(".", atpos) > atpos && emailAddress.IndexOf("@", atpos+1) <= atpos)
				{
					errorMsg = "";
					return true;
				}
			}
			errorMsg = "e-mail address must be in a valid format \nEx.: 'someone@example.com' ";
			return false;
		}

		private void tbCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (c != '\b' && !((c >= 'a' && c <= 'f') || (c <= 'F' && c >= 'A') || (c >= '0' && c <= '9')))
			{
				e.Handled = true;
			}
			if (c >= 'a' && c <= 'f')
				e.KeyChar = char.ToUpper(e.KeyChar);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Exiting...");
			this.Close();
		}

		private void cbTermsAndConditions_CheckedChanged(object sender, EventArgs e)
		{
			btnAdd.Enabled = cbTermsAndConditions.Checked;
		}
	}
}
