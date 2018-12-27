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
	public partial class ImageShow : ContentPage
	{
		public ImageShow ()
		{
			InitializeComponent ();

            //image.Source = ImageSource.FromResource("background.jpg");
        }
	}
}