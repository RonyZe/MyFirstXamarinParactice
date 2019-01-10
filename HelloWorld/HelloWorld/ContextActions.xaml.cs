using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContextActions : ContentPage
    {
//        private ObservableCollection<Contact> _contacts;
        private List<Contact> _contacts;
		public ContextActions ()
		{
			InitializeComponent ();

            //            listView.ItemsSource = new List<Contact>

            _contacts = new List<Contact>
            {
                new Contact{ Name="Mosh", ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact{ Name="John", ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hey let's talk!" }

            };

            listView.ItemsSource = _contacts;
        }

         void Call_Clicked(object sender, EventArgs e)
        {
           var menuItem= sender as MenuItem;
           var contact = menuItem.CommandParameter as Contact;

           DisplayAlert("Call", contact.Name, "OK");
        }

        void Delete_Clicked(object sender, EventArgs e)
        {
           var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }
    }
}