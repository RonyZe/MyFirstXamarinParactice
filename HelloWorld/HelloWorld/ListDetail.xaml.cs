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
	public partial class ListDetail : ContentPage
	{               
        public ListDetail()
        {           
            InitializeComponent();
        }

        
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}