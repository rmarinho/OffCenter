using System;
using System.Threading.Tasks;

namespace MCA
{
	public class LoginService : ILoginService
	{
		public async Task<bool> LoginAsync(string username, string password)
		{
			McClient.Shared.StoreCredentials(username, password);
			var sucess = await McClient.Shared.Login();
			return sucess;
		}
	}
}
