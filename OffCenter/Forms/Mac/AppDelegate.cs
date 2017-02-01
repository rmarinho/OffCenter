using System;
using AppKit;
using Foundation;
using MCA.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace MCA.macOS
{
	[Register("AppDelegate")]
	public class AppDelegate : FormsApplicationDelegate
	{

		NSWindow _window;
		public AppDelegate()
		{
			ObjCRuntime.Runtime.MarshalManagedException += (sender, args) =>
			{
				Console.WriteLine(args.Exception.ToString());
			};

			var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

			var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
			_window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
			_window.Title = "MobileCenter";
			_window.TitleVisibility = NSWindowTitleVisibility.Hidden;
		}

		public override NSWindow MainWindow
		{
			get { return _window; }
		}

		public override void DidFinishLaunching(NSNotification notification)
		{
			Forms.Init();
			DependencyService.Register<ISecureService, SecureService>();

			var app = new App();
			LoadApplication(app);
			base.DidFinishLaunching(notification);
		}
	}
}
