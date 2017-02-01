using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MCA
{
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage()
		{
			InitializeComponent();
		}

		void PopClicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
