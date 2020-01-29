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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Airport airport = new Airport("Alexander The Great", "Skopje", "SKP");
			airport.AddDestination(new Destination("Vienna", 1240, 260));
			lbAirports.Items.Add(airport);
			loadDestinations();
		}

		private void btnAddAirport_Click(object sender, EventArgs e)
		{
			AddAirport addAirport = new AddAirport();
			if (addAirport.ShowDialog() == DialogResult.OK)
			{
				lbAirports.Items.Add(addAirport.Airport);
			}
		}

		private void btnAddDestination_Click(object sender, EventArgs e)
		{
			AddDestination addDestination = new AddDestination();
			if (addDestination.ShowDialog() == DialogResult.OK)
			{
				Airport airport = lbAirports.SelectedItem as Airport;
				airport.AddDestination(addDestination.Destination);
				loadDestinations();
			}
		}

		private void btnDeleteAirport_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Want to delete this airport?", "Delete Airport", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				lbAirports.Items.RemoveAt(lbAirports.SelectedIndex);
			}
		}

		private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnDeleteAirport.Enabled = lbAirports.SelectedIndex != -1;
			btnAddDestination.Enabled = lbAirports.SelectedIndex != -1;
			loadDestinations();
		}

		private void loadDestinations()
		{
			lbDestinations.Items.Clear();
			tbAvgLngthDestinations.Clear();
			tbMostExpensiveDestination.Clear();

			Airport airport = lbAirports.SelectedItem as Airport;
			if (airport != null && airport.Destinations.Count > 0)
			{
				Destination maxPrice = airport.Destinations[0];
				float totalDistance = 0;
				foreach (Destination destination in airport.Destinations)
				{
					lbDestinations.Items.Add(destination);
					if (destination.Price > maxPrice.Price)
					{
						maxPrice = destination;
					}
					totalDistance += destination.Distance;
				}
				tbAvgLngthDestinations.Text = string.Format("{0:#.0}", totalDistance / lbDestinations.Items.Count);
				tbMostExpensiveDestination.Text = maxPrice.ToString();
			}
		}
	}
}
