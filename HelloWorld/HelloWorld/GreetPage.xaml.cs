using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();


//		    slider.Value = 0.5;

            var x = new OnPlatform<Thickness>
            {
                Android = new Thickness(0),
                iOS = new Thickness(0, 20, 0, 0)
            };

            Padding = x;
//            if (Device.OS == TargetPlatform.iOS)
//                Padding = new Thickness(0, 20, 0, 0);
//            else if (Device.OS == TargetPlatform.Android)
//                Padding = new Thickness(10, 20, 0, 0);
//            else if (Device.OS == TargetPlatform.WinPhone)
//                Padding = new Thickness(30, 20, 0, 0);
//
//            Padding = Device.OnPlatform<Thickness>(
//                iOS:new Thickness(0, 20, 0, 0),
//                Android:new Thickness(0, 20, 0, 0),
//                WinPhone:new Thickness(0, 20, 0, 0)
//                );

            //		    Content = new Label
            //		    {
            //                HorizontalOptions = LayoutOptions.Center,
            //                VerticalOptions = LayoutOptions.Center,
            //                Text = "Hello World"
            //		    };

        }

        //	    private void Handle_OnValueChanged(object sender, ValueChangedEventArgs e)
        //	    {
        //	        label.Text = String.Format("Value is {0:F2}", e.NewValue);
        //	    }

        //void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    DisplayAlert("Title", "Hello World", "OK");
        //}


    }
}