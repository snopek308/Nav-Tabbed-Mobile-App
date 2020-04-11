using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}

		async void SurpriseModal(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new UpcomingAppointmentsPage(), false);
		}
	}
}