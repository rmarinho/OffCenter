using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Azure.Mobile.Analytics;
using Xamarin.Forms;

namespace MCA
{
	public class LoginViewModel : BaseViewModel
	{
		ILoginService _loginService;
		Command _loginCommand;
		public LoginViewModel()
		{
			_loginService = DependencyService.Get<ILoginService>();

		}

		string _username;
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				SetField(ref _username, value);
				LoginCommand.ChangeCanExecute();
			}
		}

		string _password;
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				SetField(ref _password, value);
				LoginCommand.ChangeCanExecute();
			}
		}

		public Command LoginCommand => _loginCommand ?? (_loginCommand = new Command(async () =>
		{
			Analytics.TrackEvent("Login", new Dictionary<string, string> { { "User", Username } });
			var loginSucess = await _loginService.LoginAsync(Username, Password);

			Analytics.TrackEvent(loginSucess ? "LoginOK" : "LoginFailure", new Dictionary<string, string> { { "User", Username } });
			if (!loginSucess)
			{
				Password = string.Empty;
			}
		}, () => !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Username)));
	}
}
