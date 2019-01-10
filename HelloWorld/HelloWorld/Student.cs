using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
   public class Student
   {
       [PrimaryKey,NotNull,AutoIncrement]
       public int ID { get; set; }
       public string Name { set; get; }

       public string FatherName { set; get; }

       public string Address { set; get; }

       public string Class { set; get; }

       public DateTime dateofBirth { set; get; }



    }
}
