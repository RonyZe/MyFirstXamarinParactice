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
	public partial class ContextActions : ContentPage
	{
		public ContextActions ()
		{
			InitializeComponent ();
		}

        private void Call_Clicked(object sender, EventArgs e)
        {
           var menuItem= sender as MenuItem;
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}