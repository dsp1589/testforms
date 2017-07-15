using Xamarin.Forms.Platform.iOS;
using TestForms.CustomControls;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(MyEntry), typeof(TestForms.iOS.Custom.MyEntryRenderer))]
namespace TestForms.iOS.Custom
{
	public class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
                Control.BorderStyle = UIKit.UITextBorderStyle.RoundedRect;
                Control.BackgroundColor = UIKit.UIColor.White;
                Control.TextColor = UIKit.UIColor.Black;
			}
		}
	}
}