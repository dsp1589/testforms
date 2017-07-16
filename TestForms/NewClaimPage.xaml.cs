using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Plugin.Media;



namespace TestForms
{
    public partial class NewClaimPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsPickPhotoSupported){
				DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
				return;
            }

            var fileq = await CrossMedia.Current.PickPhotoAsync(null);

   //         var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
			//{

			//	Directory = "Sample",
			//	Name = "test.jpg"
			//});
			if (fileq == null)
				return;
			DisplayAlert("File Location", fileq.Path, "OK");


		}


        public NewClaimPage()
        {
            InitializeComponent();
            Title = "New Claims";
            if (Xamarin.Forms.Device.RuntimePlatform == "iOS"){
				Icon = "new";
			}
		}
        	}
}