using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClasses
{
	public class HouseList
	{
		public List<House> MasterListOfHouses;

		public HouseList()
		{
			MasterListOfHouses = new List<House>();
			MasterListOfHouses.AddRange(
				new House[] {
					new House("35 Twin Oaks",
						"Glendale",
						"J3E 2B3",
						328743,
						"House1.jpg"),
					new House("7 Shady Oaks",
						"Markham",
						"N8F 0G2",
						379099,
						"House2.jpg"),
					new House("4 Riverbank Rd",
						"Brampton",
						"N1O 6A5",
						699999,
						"House3.jpg"),
					new House("29 Seedy Ln",
						"Caledon",
						"Q5K 1T2",
						810000,
						"House4.jpg"),
					new House("7139 Pharmacy Ave",
						"Aurora",
						"J6M 6R7",
						1388000,
						"House5.jpg")
				});
		}

		public double GetAskingTotal()
		{
			double total = 0;
			foreach (House house in this.MasterListOfHouses)
			{
				total += house.Asking;
			}
			return total;
		}
		public double GetAskingAverage()
		{
			return this.GetAskingTotal() / this.MasterListOfHouses.Count;
		}

		//deciding which house to show when frmBrowseHouses first opens.
		//if all have been added already, show the last.
		public int IndexOfFirstUnaddedHouse()
		{
			for (int i = 0; i < this.MasterListOfHouses.Count; i++)
				if (this.MasterListOfHouses[i].IsAddedToList == false)
				{
					return i;

				}
			return this.MasterListOfHouses.Count - 1;
		}
	}
}
