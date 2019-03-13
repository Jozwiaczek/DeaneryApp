using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOfficeApp.Models
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string IndexNumber { get; set; }
        public string Status { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }
        public string Specialization { get; set; }
        public string Notes { get; set; }
    }
}
