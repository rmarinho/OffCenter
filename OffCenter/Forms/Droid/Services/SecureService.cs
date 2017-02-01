using System;
namespace MCA.Droid
{
	public class SecureService : ISecureService
	{
		static Tuple<string, string> s_serviceItem = new Tuple<string, string>("", "");
		public Tuple<string, string> GetItemFromKeychain(string service)
		{
			return s_serviceItem;
		}

		public bool SaveItemToKeychain(string service, string account, string privateKey)
		{
			s_serviceItem = new Tuple<string, string>(account, privateKey);
			return true;
		}

	}
}
