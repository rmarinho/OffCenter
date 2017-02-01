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
		public MainViewModel()
		{
			//Apps[0].DisplayName
		}

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

		internal Task InitAsync()
		{
			return Task.Run(() =>
			{
				Apps = new ObservableCollection<MApp>(McClient.Shared.Apps.Select((AppResponse arg) => { return new MApp { Name = arg.DisplayName, Icon = Utils.GetDefaultIcon(arg.Name), OS = arg.Os }; }));

			});
		}
	}
}
