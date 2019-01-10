using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.IO;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelloWorld.Droid.persistence;
using HelloWorld.Persistence;
using SQLite;
using Xamarin.Forms;
using Environment = System.Environment;
using Path = System.IO.Path;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloWorld.Droid.persistence
{
  public class SQLiteDb: ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}