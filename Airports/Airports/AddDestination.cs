using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
	public partial class AddDestination : Form
	{
		public Destination Destination { get; set; }
		public AddDestination()
		{
			InitializeComponent();
		}

		private void tbAddDestinationName_Validating(object sender, CancelEventArgs e)
		{
			if (tbAddDestinationName.Text.Trim().Length == 0)
			{
				errorProviderAddDestination.SetError(tbAddDestinationName, "Name is required!");
				e.Cancel = true;
			}
			else
			{
				errorProviderAddDestination.SetError(tbAddDestinationName, "");
				e.Cancel = false;
			}
		}

		private void btnAddDestinationSave_Click(object sender, EventArgs e)
		{
			Destination = new Destination(tbAddDestinationName.Text.Trim(), (int)nudAddDestinationLength.Value, (int)nudAddDestinationPrice.Value);
			DialogResult = DialogResult.OK;
		}

		private void btnAddDestinationCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
