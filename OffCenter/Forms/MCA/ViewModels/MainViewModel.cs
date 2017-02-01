using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using NomadCode.MobileCenter.Models;
using System.Linq;
using Xamarin.Forms;

namespace MCA
{
	public class MainViewModel : BaseViewModel
	{

		ObservableCollection<MApp> _apps;
		public ObservableCollection<MApp> Apps
		{
			get
			{
				return _apps;
			}
			set
			{
				SetField(ref _apps, value);
			}
		}

		Owner _user;
		public Owner User
		{
			get
			{
				return _user;
			}
			set
			{
				SetField(ref _user, value, additionalprops: new[] { nameof(UserAvatarUrl) });
			}
		}

		public ImageSource UserAvatarUrl
		{
			get
			{
				return User?.AvatarUrl == null ? ImageSource.FromUri(new Uri(Utils.GetFakeAvatar())) : ImageSource.FromUri(new Uri(User.AvatarUrl));
			}
		}

		internal Task InitAsync()
		{
			return Task.Run(() =>
			{
				Apps = new ObservableCollection<MApp>(McClient.Shared.Apps.Select((AppResponse arg) => { return new MApp { Name = arg.DisplayName, Icon = Utils.GetDefaultIcon(arg.Name), OS = arg.Os }; }));
				if (Apps.Count > 0)
					User = McClient.Shared.Apps.First().Owner;

			});
		}
	}
}
