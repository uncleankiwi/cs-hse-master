using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseClasses;

namespace Project1
{
	public partial class frmAddHouse : Form
	{
		//for passing info between forms. 
		public static HouseList houseListAH = new HouseList();
		public static List<string> houseToStringListAH = new List<string>();

		public frmAddHouse()
		{
			InitializeComponent();

			this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
			this.Left = 100;
		}

		private void mnuViewExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void mnuViewHouse_Click(object sender, EventArgs e)
		{
			frmBrowseHouses frmbrowsehouse = new frmBrowseHouses();
			frmbrowsehouse.ShowDialog();
		}

		private void frmAddHouse_Activated(object sender, EventArgs e)
		{
			//adding the houses that were added in frmBrowseHouse
			foreach (string newHouseString in houseToStringListAH)
			{
				lstAddHouse.Items.Add(newHouseString);
			}
			houseToStringListAH.Clear();
		}
	}
}
