using System;
using Foundation;
using Security;

namespace MCA.iOS
{
	public class SecureService : ISecureService
	{
		public Tuple<string, string> GetItemFromKeychain(string service)
		{
			SecStatusCode status;

			var record = SecKeyChain.QueryAsRecord(GenericRecord(service), out status);

			if (status == SecStatusCode.Success && record != null)
			{
				var account = record.Account;

				var privateKey = NSString.FromData(record.ValueData, NSStringEncoding.UTF8).ToString();

				return new Tuple<string, string>(account, privateKey);
			}

			return null;
		}

		public bool SaveItemToKeychain(string service, string account, string privateKey)
		{
			SecStatusCode oldStatus;

			// Delete any existing items
			var oldRecord = SecKeyChain.QueryAsRecord(GenericRecord(service), out oldStatus);

			if (oldStatus == SecStatusCode.Success && oldRecord != null)
			{
				RemoveItemFromKeychain(service);
			}
			var record = GenericRecord(service);
			record.Account = account;
			record.ValueData = NSData.FromString(privateKey, NSStringEncoding.UTF8);

			// Add the new keychain item
			var status = SecKeyChain.Add(record);

			var success = status == SecStatusCode.Success;

			if (!success)
			{
				System.Diagnostics.Debug.WriteLine($"Error in Keychain: {status}");
				System.Diagnostics.Debug.WriteLine($"If you are seeing error code '-34018' got to Project Options -> iOS Bundle Signing -> make sure Entitlements.plist is populated for Custom Entitlements for iPhoneSimulator configs");
			}

			return success;
		}


		SecRecord GenericRecord(string service) => new SecRecord(SecKind.GenericPassword)
		{
			Service = $"{NSBundle.MainBundle.BundleIdentifier}-{service}"
		};

		void RemoveItemFromKeychain(string service)
		{
			var record = GenericRecord(service);

			SecKeyChain.Remove(record);
		}

	}
}
