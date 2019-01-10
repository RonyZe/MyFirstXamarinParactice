using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    

    public partial class MainPage: ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

//            _contactMethods = GetContactMethods();
//            foreach (var method in _contactMethods)
//                contactMethods.Items.Add(method.Name);

//            new NavigationPage(new ContactDetailPage());
//            this.Children.Add(new ContentPage());
//            this.Children.Add(new NavigationPage(new ContentPage()));

        }


//
//        private async void Button_OnClicked(object sender, EventArgs e)
//        {
//
//          var response = await DisplayActionSheet("Title","Cancel","Delete","Copy Link","Message","Email","Extra Button");
//          await DisplayAlert("Response", response, "OK");
//
////            var response = await DisplayAlert("Last Warning","Are you sure?","Yes","No");
////            if (response)
////                DisplayAlert("Done", "Your response will be saved!", "OK");
//
//        }


//        private void MenuItem_OnClicked(object sender, EventArgs e)
//        {
//            DisplayAlert("Activated", "ToolbarItem Activated", "OK");
//        }


        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
//            label.Text = e.NewTextValue;
        }

//        private IList<ContactMethod> _contactMethods;
//        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
//        {
//            var name = contactMethods.Items[contactMethods.SelectedIndex];
//            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
//
//            DisplayAlert("Selection", name, "OK");
//        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod {Id = 1, Name = "SMS"},
                new ContactMethod {Id = 2, Name = "Email"}
            };
        }

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cell_OnTapped(object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }
    }
}
