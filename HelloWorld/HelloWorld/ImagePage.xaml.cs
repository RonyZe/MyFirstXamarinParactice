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
	public partial class ImagePage : ContentPage
	{
        public List<Student> listofStudents;
		public ImagePage()
        {
            listofStudents = new List<Student>();
            listofStudents.Add(new Student()
            {
                ID = 1, Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            }); listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            }); listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            }); listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });
            listofStudents.Add(new Student()
            {
                ID = 1,
                Name = "Ali",
                FatherName = "Saeed",
                Address = "Lahore",
                Class = "1st",
                dateofBirth = DateTime.Now
            });

            InitializeComponent ();
            listView.ItemsSource = listofStudents;
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
              var studentDeatil = e.Item as Student;
            await Navigation.PushAsync(new ListDetail());
        }
    }
}