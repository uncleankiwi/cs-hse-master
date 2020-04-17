using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClasses
{
	public class House
	{
		public string Address { get; set; }
		public string City { get; set; }
		public string Zip { get; set; }
		public double Asking { get; set; }
		public string Filename { get; set; }
		public bool IsAddedToList { get; set; }

		public House(string address, string city, string zip, double asking, string filename)
		{
			this.Address = address;
			this.City = city;
			this.Zip = zip;
			this.Asking = asking;
			this.Filename = filename;
			this.IsAddedToList = false;
		}

		public override string ToString()
		{
			return this.Address + ", " + this.City + " with a price of " + String.Format("{0:c}", this.Asking);
			
		}
	}
}
