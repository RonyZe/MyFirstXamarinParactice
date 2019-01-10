using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Persistence;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Student> students;

        public ImagePage()
        {
            
            InitializeComponent ();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        //        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        //        {
        //              var studentDeatil = e.Item as Student;
        //            await Navigation.PushAsync(new ListDetail());
        //        }
        protected async override void OnAppearing()
        {
             await _connection.CreateTableAsync<Student>();
            var abc = await _connection.QueryAsync<Student>("select * from Student order by ID desc");
            students = new ObservableCollection<Student>(abc);
            listView.ItemsSource = students;

            base.OnAppearing();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = sender as ListView;
            var stu = listView.SelectedItem as Student;
            ViewCell viewCell;
            //            viewCell.BindingContext;
            var action = await DisplayActionSheet(e.SelectedItem.ToString(), "Cancel", "Edit", "Delete");
            switch (action)
            {
                case "Edit":
                    await Navigation.PushAsync(new ListDetail(stu));
                    break;
                case "Delete":
                    var del = students[0];
                    _connection.DeleteAsync(del);
                    students.Remove(del);
                    break;
            }
            
            //            listView.ItemTemplate.SetBinding(Label.BindingContextProperty, "Name");
            //            var index = (listView.ItemsSource as List<Student>).(e.SelectedItem as Student); 
          
        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListDetail());
        }

//        private void ListView_OnItemDisappearing(object sender, ItemVisibilityEventArgs e)
//        {
//            var del = students[0];
//            _connection.DeleteAsync(del);
//            students.Remove(del);
//        }
    }
}