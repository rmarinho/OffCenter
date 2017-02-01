using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MCA
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			BackgroundColor = Colors.DarkGrayColor;
			InitializeComponent();
			BindingContext = new LoginViewModel();
		}
	}
}
