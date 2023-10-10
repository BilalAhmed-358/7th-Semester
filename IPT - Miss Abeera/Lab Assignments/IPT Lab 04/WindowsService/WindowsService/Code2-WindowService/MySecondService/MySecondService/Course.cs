using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondService
{
    [Serializable]
    public class Course
    {
        public string StudentName { get; set; }
        public string CourseName { get; set; }

        public Course()
        { }
        public Course(string _studentName, string _courseName)
        {
            this.CourseName = _courseName;
            this.StudentName = _studentName;
        }
    }
}
