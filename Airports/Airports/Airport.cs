using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
	public class Airport
	{
		public string City { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public List<Destination> Destinations;

		public Airport(string city, string name, string shortName)
		{
			City = city;
			Name = name;
			ShortName = shortName;
			Destinations = new List<Destination>();
		}

		public void AddDestination(Destination destination)
		{
			Destinations.Add(destination);
		}

		public override string ToString()
		{
			return string.Format("{0} - {1} - {2}", ShortName, Name, City);
		}
	}
}
