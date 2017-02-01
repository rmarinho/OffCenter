using System;
using Xamarin.Forms;

namespace MCA
{
	public class MApp
	{
		public string Name
		{
			get;
			set;
		}

		public string Detail => $"for {OS}";

		public string IconText => char.ToUpperInvariant(Name[0]).ToString();

		public Color IconTextColor => Utils.GetDefaultIconTextColor(Name);

		public string OS
		{
			get;
			set;
		}

		public ImageSource Icon
		{
			get;
			set;
		}
	}
}
