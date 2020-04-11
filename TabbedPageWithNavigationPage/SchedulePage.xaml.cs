using System;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SchedulePage : ContentPage
	{
		public static string result;
		public SchedulePage ()
		{
			InitializeComponent ();
		}

		public void CalculateYears(Object sender, EventArgs args)
		{
			int numberEntry = Convert.ToInt32(Age.Text);
			var currentDate = DateTime.Now;
			var currentYear = currentDate.Year;

			if(currentYear - numberEntry > 16)
			{
				result = currentYear - numberEntry - 16 + "";
				Output.Text = "You have been able to drive legally for " + result + " years.";
			}
			else if(currentYear - numberEntry == 16)
			{
				result = "0";
				Output.Text = "You have been able to drive legally for " + result + " years.";
			}
			else
			{
				Output.Text = "You are not legally old enough to drive in Wisconsin.";
			}

		}
	}
}

