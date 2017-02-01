using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Rest;
using NomadCode.MobileCenter;
using NomadCode.MobileCenter.Models;
using Xamarin.Forms;

namespace MCA
{
	public class McClient
	{
		ISecureService _secureService;
		MobileCenterClient _mobileCenterClient;
		static McClient s_shared;

		public McClient()
		{
			_secureService = DependencyService.Get<ISecureService>();
		}

		public event EventHandler<bool> Authenticated;

		public List<AppResponse> Apps { get; set; } = new List<AppResponse>();


		public static McClient Shared => s_shared ?? (s_shared = new McClient());

		public async Task<bool> Login()
		{
			var userCreds = _secureService.GetItemFromKeychain(Keys.Keychain.Account);

			if (string.IsNullOrEmpty(userCreds?.Item1) || string.IsNullOrEmpty(userCreds?.Item2))
			{
				return false;
			}

			_mobileCenterClient = new MobileCenterClient(new BasicAuthenticationCredentials
			{
				UserName = userCreds.Item1,
				Password = userCreds.Item2
			});

			try
			{
				var token = _secureService.GetItemFromKeychain(Keys.Keychain.Token);

				if (string.IsNullOrEmpty(token?.Item1) || string.IsNullOrEmpty(token?.Item2))
				{
					var tokensObj = await _mobileCenterClient.Account.CreateApiTokenAsync(new ApiTokensCreateRequest(Keys.Client.TokenDescription));

					var tokens = tokensObj as ApiTokensCreateResponse;

					if (!string.IsNullOrEmpty(tokens?.ApiToken))
					{
						_secureService.SaveItemToKeychain(Keys.Keychain.Token, tokens.Id, tokens.ApiToken);

						_mobileCenterClient.HttpClient.DefaultRequestHeaders.Add(Keys.Client.TokenHeader, tokens.ApiToken);
					}
				}
				else
				{
					_mobileCenterClient.HttpClient.DefaultRequestHeaders.Add(Keys.Client.TokenHeader, token.Item2);
				}

				// this will fail if we're not authenticated
				var authed = await GetApps();

				Authenticated?.Invoke(this, authed);

				return authed;
			}
			catch (System.Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
				return false;
			}
		}
		public async Task<bool> GetBuilds(AppResponse app)
		{
			try
			{

				return true;
			}
			catch (System.Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
				return false;
			}
		}

		async Task<bool> GetApps()
		{
			try
			{
				var appsObj = await _mobileCenterClient.Account.GetAppsAsync();

				var apps = appsObj as List<AppResponse>;

				Apps = apps.OrderBy(a => a.DisplayName).ToList();
				var s = McClient.Shared.GetBuilds(Apps.First());
				return Apps?.Count > 0;
			}
			catch (System.Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
				return false;
			}
		}


		public void StoreCredentials(string username, string password) => _secureService.SaveItemToKeychain(Keys.Keychain.Account, username, password);
	}
}
