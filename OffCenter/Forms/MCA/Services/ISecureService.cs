using System;
namespace MCA
{
	public interface ISecureService
	{
		Tuple<string, string> GetItemFromKeychain(string service);

		bool SaveItemToKeychain(string service, string account, string privateKey);
	}
}
