using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HouseClasses;

namespace Project1
{
	public partial class frmBrowseHouses : Form
	{
		int browsingIndex = 0;
		int browsingLimit;

		public static HouseList houseListBH;
		List<string> houseToStringListBH;	//read-only

		public frmBrowseHouses()
		{
			InitializeComponent();

			//for passing info between forms. List<string> holding ToString() is refreshed, List<House> isn't.
			houseListBH = frmAddHouse.houseListAH;
			houseToStringListBH = new List<string>();

			//populating controls
			browsingIndex = houseListBH.IndexOfFirstUnaddedHouse();
			PopulateControls(browsingIndex);
			browsingLimit = houseListBH.MasterListOfHouses.Count() - 1;
			txtAveragePrice.Text = string.Format("{0:c}", houseListBH.GetAskingAverage());
			txtTotalPrice.Text = string.Format("{0:c}", houseListBH.GetAskingTotal());

			//window placement
			this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
			//System.Windows.SystemParameters.VirtualScreenWidth;
			this.Left = 100 + Application.OpenForms[0].Width;
			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		//browsing controls
		private void btnNext_Click(object sender, EventArgs e)
		{
			if (browsingIndex < browsingLimit)
			{
				browsingIndex++;
				PopulateControls(browsingIndex);
			}
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (browsingIndex > 0)
			{
				browsingIndex--;
				PopulateControls(browsingIndex);
			}
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			if (browsingIndex != browsingLimit)
			{
				browsingIndex = browsingLimit;
				PopulateControls(browsingIndex);
			}
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			if (browsingIndex != 0)
			{
				browsingIndex = 0;
				PopulateControls(browsingIndex);
			}
		}

		private void frmBrowseHouses_FormClosed(object sender, FormClosedEventArgs e)
		{
			//communicating with parent form before this form disappears.
			frmAddHouse.houseToStringListAH = houseToStringListBH;
			frmAddHouse.houseListAH = houseListBH;
		}

		private void frmBrowseHouses_FormClosing(object sender, FormClosingEventArgs e)
		{
			//communicating with parent form before this form disappears.
			frmAddHouse.houseToStringListAH = houseToStringListBH;
			frmAddHouse.houseListAH = houseListBH;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//adds current house's ToString() to List<String>
			if (houseListBH.MasterListOfHouses[browsingIndex].IsAddedToList == false)
			{
				//but only if the user confirms
				if (MessageBox.Show("Do you want to add this house?", "Add House", MessageBoxButtons.YesNo,
					MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					houseToStringListBH.Add(houseListBH.MasterListOfHouses[browsingIndex].ToString());
					houseListBH.MasterListOfHouses[browsingIndex].IsAddedToList = true;
					btnNext.PerformClick();

				}
			}
		}

		//fills text boxes and picture box with the house at MasterListOfHouses[index]
		private void PopulateControls(int index)
		{
			txtAddress.Text = houseListBH.MasterListOfHouses[index].Address;
			txtCity.Text = houseListBH.MasterListOfHouses[index].City;
			txtZip.Text = houseListBH.MasterListOfHouses[index].Zip;
			txtAsking.Text = string.Format("{0:c}", houseListBH.MasterListOfHouses[index].Asking);
			txtFilename.Text = houseListBH.MasterListOfHouses[index].Filename;
			picHouse.ImageLocation = System.IO.Path.Combine(
				Application.StartupPath, "House images", txtFilename.Text);
		}

	}
}
