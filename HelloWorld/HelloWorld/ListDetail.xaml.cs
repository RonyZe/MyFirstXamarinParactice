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
	public partial class ListDetail : ContentPage
	{

        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Student> students;
        public ListDetail()
        {           
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        public ListDetail(Student student)
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            Name.Text = student.Name;
            FatherName.Text = student.FatherName;
            Address.Text = student.Address;
            Dob.Date = student.dateofBirth;
        }

        protected async override void OnAppearing()
        {
            await _connection.CreateTableAsync<Student>();
            var abc = await _connection.Table<Student>().ToListAsync();
            students = new ObservableCollection<Student>(abc);

            base.OnAppearing();
        }


        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var student = new Student { Name = Name.Text, FatherName=FatherName.Text, Address=Address.Text, dateofBirth=Dob.Date};
            await _connection.InsertAsync(student);            
            students.Add(student);
            
            await Navigation.PopAsync();

        }

    }
}