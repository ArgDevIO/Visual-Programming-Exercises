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
	public partial class AddAirport : Form
	{
		public Airport Airport { get; set; }
		public AddAirport()
		{
			InitializeComponent();
		}

		private void tbAddAirportCity_Validating(object sender, CancelEventArgs e)
		{
			if (tbAddAirportCity.Text.Trim().Length == 0)
			{
				errorProviderAddAirport.SetError(tbAddAirportCity, "City name is required!");
				e.Cancel = true;
			}
			else
			{
				errorProviderAddAirport.SetError(tbAddAirportCity, "");
				e.Cancel = false;
			}
		}

		private void tbAddAirportName_Validating(object sender, CancelEventArgs e)
		{
			if (tbAddAirportName.Text.Trim().Length == 0)
			{
				errorProviderAddAirport.SetError(tbAddAirportName, "Name is required!");
				e.Cancel = true;
			}
			else
			{
				errorProviderAddAirport.SetError(tbAddAirportName, "");
				e.Cancel = false;
			}
		}

		private void tbAddAirportShortcut_Validating(object sender, CancelEventArgs e)
		{
			string shortName = tbAddAirportShortname.Text.Trim();
			if (shortName.Length != 3 || !shortName.All(c => Char.IsUpper(c)))
			{
				errorProviderAddAirport.SetError(tbAddAirportShortname, "Shortname must have exactly 3 Upper Case Letters!");
				e.Cancel = true;
			}
			else
			{
				errorProviderAddAirport.SetError(tbAddAirportShortname, "");
				e.Cancel = false;
			}
		}

		private void btnAddAirportSave_Click(object sender, EventArgs e)
		{
			Airport = new Airport(tbAddAirportName.Text.Trim(), tbAddAirportCity.Text.Trim(), tbAddAirportShortname.Text.Trim());
			DialogResult = DialogResult.OK;
		}

		private void btnAddAirportCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
