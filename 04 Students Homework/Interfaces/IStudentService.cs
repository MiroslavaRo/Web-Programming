using _04_Students_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Students_Homework.Interfaces
{
    public interface IStudentService
    {
        IList<StudentViewModel> GetStudents(string firstName, string lastName);

        StudentViewModel GetStudent(int studentNumber);
    }
}
