using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MCA
{
	public partial class BeaconsPage : ContentPage
	{
		public BeaconsPage()
		{
			InitializeComponent();
			BindingContext = new BeaconsViewModel();
		}

		void HandleItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{

		}
	}
}
