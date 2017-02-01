using System;
using Xamarin.Forms;

namespace MCA
{
	internal static class Utils
	{
		public static string GetDefaultIcon(string name)
		{
			var firstLetter = char.ToLowerInvariant(name[0]);

			if (firstLetter < 'p') return "i_app_icon_default_green";

			if (firstLetter < 's') return "i_app_icon_default_yellow";

			if (firstLetter < 't') return "i_app_icon_default_orange";

			if (firstLetter < 'u') return "i_app_icon_default_purple";

			if (firstLetter < 'x') return "i_app_icon_default_blue";

			return "i_app_icon_default_green";
		}

		public static Color GetDefaultIconTextColor(string name)
		{
			var firstLetter = char.ToLowerInvariant(name[0]);

			if (firstLetter < 'p') return Colors.DefaultIconText.Green;

			if (firstLetter < 's') return Colors.DefaultIconText.Yellow;

			if (firstLetter < 't') return Colors.DefaultIconText.Orange;

			if (firstLetter < 'u') return Colors.DefaultIconText.Purple;

			if (firstLetter < 'x') return Colors.DefaultIconText.Blue;

			return Colors.DefaultIconText.Green;
		}

		public static Color GetDefaultStatusTextColor(BuildStatus status)
		{
			switch (status)
			{
				case BuildStatus.Abort:
					return Color.Yellow.MultiplyAlpha(0.5);
				case BuildStatus.Building:
					return Color.Blue.MultiplyAlpha(0.5);
				case BuildStatus.Built:
					return Color.Green.MultiplyAlpha(0.5);
				case BuildStatus.Fail:
					return Color.Red.MultiplyAlpha(0.5);
			}

			return Color.Gray.MultiplyAlpha(0.5);
		}

		public static string GetFakeAvatar()
		{
			return string.Format("https://www.gravatar.com/avatar/{0}?s=200", "96523af99438b25dd0a362e11ec31021");
		}
	}
}
