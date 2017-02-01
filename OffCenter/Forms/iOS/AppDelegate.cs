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
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}


	//public class CustomImageRenderer : ViewRenderer<Image, UIImageView>
	//{

	//	bool _isDisposed;

	//	IElementController ElementController => Element as IElementController;

	//	protected override void Dispose(bool disposing)
	//	{
	//		if (_isDisposed)
	//			return;

	//		if (disposing)
	//		{
	//			UIImage oldUIImage;
	//			if (Control != null && (oldUIImage = Control.Image) != null)
	//			{
	//				oldUIImage.Dispose();
	//				oldUIImage = null;
	//			}
	//		}

	//		_isDisposed = true;

	//		base.Dispose(disposing);
	//	}

	//	protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
	//	{
	//		if (Control == null)
	//		{
	//			var imageView = new UIImageView(RectangleF.Empty);
	//			imageView.ContentMode = UIViewContentMode.ScaleAspectFit;
	//			imageView.ClipsToBounds = true;
	//			SetNativeControl(imageView);
	//		}

	//		if (e.NewElement != null)
	//		{
	//			SetAspect();
	//			SetImage(e.OldElement);
	//			SetOpacity();
	//		}

	//		base.OnElementChanged(e);
	//	}

	//	protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
	//	{
	//		base.OnElementPropertyChanged(sender, e);
	//		if (e.PropertyName == Image.SourceProperty.PropertyName)
	//			SetImage();
	//		else if (e.PropertyName == Image.IsOpaqueProperty.PropertyName)
	//			SetOpacity();
	//		else if (e.PropertyName == Image.AspectProperty.PropertyName)
	//			SetAspect();
	//	}

	//	void SetAspect()
	//	{
	//		Control.ContentMode = Element.Aspect.ToUIViewContentMode();
	//	}

	//	async void SetImage(Image oldElement = null)
	//	{
	//		var source = Element.Source;

	//		if (oldElement != null)
	//		{
	//			var oldSource = oldElement.Source;
	//			if (Equals(oldSource, source))
	//				return;

	//			if (oldSource is FileImageSource && source is FileImageSource && ((FileImageSource)oldSource).File == ((FileImageSource)source).File)
	//				return;

	//			Control.Image = null;
	//		}

	//		IImageSourceHandler handler;

	//		((IImageController)Element).SetIsLoading(true);

	//		handler = new FileImageSourceHandler();
	//		//if (source != null && (handler = Registrar.Registered.GetHandler<IImageSourceHandler>(source.GetType())) != null)
	//		//{
	//		UIImage uiimage;
	//		try
	//		{
	//			uiimage = await handler.LoadImageAsync(source, scale: (float)UIScreen.MainScreen.Scale);
	//		}
	//		catch (OperationCanceledException)
	//		{
	//			uiimage = null;
	//		}

	//		var imageView = Control;
	//		if (imageView != null)
	//			imageView.Image = uiimage;

	//		if (!_isDisposed)
	//			((IVisualElementController)Element).NativeSizeChanged();
	//		//}
	//		//else
	//		//	Control.Image = null;

	//		if (!_isDisposed)
	//			((IImageController)Element).SetIsLoading(false);
	//	}

	//	void SetOpacity()
	//	{
	//		Control.Opaque = Element.IsOpaque;
	//	}
	//}

	//public interface IImageSourceHandler : IRegisterable
	//{
	//	Task<UIImage> LoadImageAsync(ImageSource imagesource, CancellationToken cancelationToken = default(CancellationToken), float scale = 1);
	//}

	//public sealed class FileImageSourceHandler : IImageSourceHandler
	//{
	//	public Task<UIImage> LoadImageAsync(ImageSource imagesource, CancellationToken cancelationToken = default(CancellationToken), float scale = 1f)
	//	{
	//		UIImage image = null;
	//		var filesource = imagesource as FileImageSource;
	//		if (filesource != null)
	//		{
	//			var file = filesource.File;
	//			if (!string.IsNullOrEmpty(file))
	//				image = UIImage.FromBundle(file);
	//		}
	//		return Task.FromResult(image);
	//	}
	//}

	//public sealed class StreamImagesourceHandler : IImageSourceHandler
	//{
	//	public async Task<UIImage> LoadImageAsync(ImageSource imagesource, CancellationToken cancelationToken = default(CancellationToken), float scale = 1f)
	//	{
	//		UIImage image = null;
	//		var streamsource = imagesource as StreamImageSource;
	//		if (streamsource != null && streamsource.Stream != null)
	//		{
	//			using (var streamImage = await ((IStreamImageSource)streamsource).GetStreamAsync(cancelationToken).ConfigureAwait(false))
	//			{
	//				if (streamImage != null)
	//					image = UIImage.LoadFromData(NSData.FromStream(streamImage), scale);
	//			}
	//		}
	//		return image;
	//	}
	//}
}

