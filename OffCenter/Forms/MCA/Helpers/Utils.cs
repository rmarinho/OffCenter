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
	}
}
