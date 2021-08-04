using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.BonusChallenge
{
    public class Student
    {
        public int StudenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Professor Professor { get; set; }
        public int AdvisorId { get; set; }
        List<StudentCourse> StudentCourses { get; set; }
        List<Course> Courses { get; set; }
    }
}
