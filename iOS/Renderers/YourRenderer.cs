using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryRenderer))]

namespace TestForms.iOS.Renderers
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer()
        {
        }
		protected override void OnModelSet(VisualElement model)
		{
			base.OnModelSet(model);
			UITextField textField = (UITextField)Control;
			textField.Font = UIFont.FromName("Ubuntu-light", 13);
			textField.BorderStyle = UITextBorderStyle.None;
			// edit more properties
		}
    }
}
