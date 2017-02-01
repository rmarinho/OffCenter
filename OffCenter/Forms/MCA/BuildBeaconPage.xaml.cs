using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MCA
{
	public partial class BuildBeaconPage : ContentPage
	{
		public BuildBeaconPage()
		{
			InitializeComponent();
			BindingContext = new BuildBeaconViewModel();
		}
	}
}
