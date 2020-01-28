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
	}
}
