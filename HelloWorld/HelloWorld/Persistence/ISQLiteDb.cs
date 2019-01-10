using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Persistence
{
    interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
