﻿using System.Threading.Tasks;
using NomadCode.MobileCenter;
using Xamarin.Forms;

namespace MCA
{
	public partial class MCAPage : ContentPage
	{
		bool showingModal;
		public MCAPage()
		{
			InitializeComponent();
			this.BindingContext = new MainViewModel();
			McClient.Shared.Authenticated += async (sender, e) =>
			{
				if (e)
				{

					await ViewModel.InitAsync();
					if (showingModal)
						await Task.WhenAll(lstApps.FadeTo(1, 600), Navigation.PopModalAsync());
					showingModal = false;
				}
			};
		}

		MainViewModel ViewModel
		{
			get { return BindingContext as MainViewModel; }
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			var auth = await McClient.Shared.Login();

			if (!auth)
			{
				showingModal = true;
				await Navigation.PushModalAsync(new LoginPage());
			}
			else
			{
				await Task.WhenAll(ViewModel.InitAsync(), lstApps.FadeTo(1, 600));
			}

		}

		async void HandleItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			await Navigation.PushAsync(new BeaconsPage());
		}

		async void HandleProfileClicked(object sender, System.EventArgs e)
		{
			await Navigation.PushModalAsync(new ProfilePage { BindingContext = this.BindingContext });
		}
	}
}
