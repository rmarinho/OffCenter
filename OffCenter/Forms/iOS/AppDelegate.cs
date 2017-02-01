using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using MCA.iOS;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.ComponentModel;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

//[assembly: ExportRenderer(typeof(Image), typeof(CustomImageRenderer))]

namespace MCA.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			UITabBar.Appearance.TintColor = MCA.Colors.Theme.ToUIColor();
			DependencyService.Register<ISecureService, SecureService>();
			MobileCenter.Configure("9c463df1-36e3-46f5-9d20-7560f7ceedce");
			LoadApplication(new App());
			return base.FinishedLaunching(app, options);
		}
	}
}

