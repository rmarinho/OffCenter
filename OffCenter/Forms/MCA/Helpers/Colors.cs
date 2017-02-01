using System;
using Xamarin.Forms;

namespace MCA
{
	public static class Colors
	{
		public static Color DarkGrayColor = Color.FromHex("2c2c2c");

		public static Color Theme = Color.FromRgba(3f / 255f, 169f / 255f, 244f / 255f, 1.0f);

		public static Color TabBarTint = Color.FromRgba(18f / 255, 136f / 255f, 209f / 255f, 1.0f);

		public static Color TabBarTextNormal = Color.FromRgba(65f / 255f, 65f / 255f, 65f / 255f, 1.0f);

		public static Color TabBarTextSelected = Color.FromRgba(18f / 255, 136f / 255f, 209f / 255f, 1.0f); //UIColor.FromRGBA (2f / 255f, 136f / 255f, 209f / 255f, 1.0f);

		public static Color DisabledRed = Color.Red.MultiplyAlpha(0.6f);


		public static class DefaultIconText
		{
			public static Color Blue = Color.FromRgba(49f / 255f, 146f / 255f, 179f / 255f, 1.0f);

			public static Color Green = Color.FromRgba(111f / 255f, 162f / 255f, 46f / 255f, 1.0f);

			public static Color Orange = Color.FromRgba(226f / 255f, 85f / 255f, 61f / 255f, 1.0f);

			public static Color Purple = Color.FromRgba(126f / 255f, 104f / 255f, 194f / 255f, 1.0f);

			public static Color Yellow = Color.FromRgba(240f / 255f, 178f / 255f, 64f / 255f, 1.0f);
		}
	}
}