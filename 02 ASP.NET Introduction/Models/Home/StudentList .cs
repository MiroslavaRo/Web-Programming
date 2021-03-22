using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_ASP.NET_Introduction.Models.Home
{
    public class StudentList
    {
        public List<Student> Students{get;set;}
      //  public string Class { get; set; }
        public StudentList()
        {
            Students = new List<Student>();
        }

    }
}
