using System;
namespace MCA.Droid
{
	public class SecureService : ISecureService
	{
		public Tuple<string, string> GetItemFromKeychain(string service)
		{
			return null;
		}

		public bool SaveItemToKeychain(string service, string account, string privateKey)
		{

			return false;
		}

	}
}
