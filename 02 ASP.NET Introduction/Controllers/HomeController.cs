using _02_ASP.NET_Introduction.Models;
using _02_ASP.NET_Introduction.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _02_ASP.NET_Introduction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Students()
        {
            StudentList studentsViewModel = new StudentList();

          //  studentsViewModel.Class = "Web Development";

            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Alex",
                LastName = "White",
                StudentNumber = 1
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Lee",
                LastName = "Yunk",
                StudentNumber = 2
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Bob",
                LastName = "Thill",
                StudentNumber = 3
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "John",
                LastName = "Brown",
                StudentNumber = 4
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Kate",
                LastName = "Mil",
                StudentNumber = 5
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Joseph",
                LastName = "Jostar",
                StudentNumber = 6
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "John",
                LastName = "Smith",
                StudentNumber = 7
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Colen",
                LastName = "Gray",
                StudentNumber = 8
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Ralph",
                LastName = "Lilo",
                StudentNumber = 9
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Sandra",
                LastName = "Bravo",
                StudentNumber = 10
            });
            return View(studentsViewModel);
        }
    }
}
