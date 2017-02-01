using System;

using Xamarin.Forms;

namespace MCA
{
	public enum BuildStatus
	{
		None,
		Building,
		Built,
		Fail,
		Abort
	}

	public class MBuild
	{
		public string CommitMessage
		{
			get;
			set;
		}

		public string CommitUser
		{
			get;
			set;
		}

		public ImageSource CommitUserImage
		{
			get;
			set;
		}

		public BuildStatus BranchStatus
		{
			get;
			set;
		}

		public string BranchStatusText => BranchStatus.ToString().ToUpper();

		public string BranchName
		{
			get;
			set;
		}

		public string Trigger
		{
			get;
			set;
		}

		public string Date
		{
			get;
			set;
		}

		public Color BranchStatusColor => Utils.GetDefaultStatusTextColor(BranchStatus);
	}
}

