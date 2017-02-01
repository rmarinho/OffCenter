using System;
using System.Threading.Tasks;

namespace MCA
{
	public class LoginService : ILoginService
	{
		public LoginService()
		{
		}

		public async Task<bool> LoginAsync(string username, string password)
		{
			McClient.Shared.StoreCredentials(username, password);
			await McClient.Shared.Login();
			return true;
		}
	}
}
