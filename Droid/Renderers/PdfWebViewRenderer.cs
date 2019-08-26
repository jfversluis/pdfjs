using Android.Content;
using pdfjs.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WebView), typeof(PdfWebViewRenderer))]
namespace pdfjs.Droid
{
	public class PdfWebViewRenderer : WebViewRenderer
	{
		public PdfWebViewRenderer(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				Control.Settings.AllowFileAccess = true;
				Control.Settings.AllowFileAccessFromFileURLs = true;
				Control.Settings.AllowUniversalAccessFromFileURLs = true;
			}
		}
		
		// If you want to enable scrolling in WebView uncomment the following lines.
		//public override bool DispatchTouchEvent(MotionEvent e)
		//{
		//    Parent.RequestDisallowInterceptTouchEvent(true);
		//    return base.DispatchTouchEvent(e);
		//}
	}
}
