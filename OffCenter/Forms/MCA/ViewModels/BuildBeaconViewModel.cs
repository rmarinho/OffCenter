using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MCA
{
	public class BuildBeaconViewModel : BaseViewModel
	{
		public BuildBeaconViewModel()
		{
			Builds = new ObservableCollection<MBuild>();

			for (int i = 0; i < 5; i++)
			{
				Builds.Add(new MBuild
				{
					BranchStatus = BuildStatus.None,
					BranchName = $"Branch {i}",
					Date = $"{i + 2} minutes ago",
					Trigger = "on push",
					CommitMessage = "This was a good commit",
					CommitUser = "Rui Marinho",
					CommitUserImage = ImageSource.FromUri(new Uri(Utils.GetFakeAvatar()))
				});
			}
			Builds[0].BranchStatus = BuildStatus.Building;
			Builds[1].BranchStatus = BuildStatus.None;
			Builds[1].BranchStatus = BuildStatus.Abort;

		}

		ObservableCollection<MBuild> _builds;
		public ObservableCollection<MBuild> Builds
		{
			get
			{
				return _builds;
			}
			set
			{
				SetField(ref _builds, value);
			}
		}
	}
}
