using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This the defalut Action";
        }
        public string GetStudentID()
        {
            return "This is the StudentID Action";
        }
        public string GetStudentName()
        {
            return "This is the StudentName Action";
        }
    }
}
