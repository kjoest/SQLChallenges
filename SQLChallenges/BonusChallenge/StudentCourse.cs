using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.BonusChallenge
{
    public class StudentCourse
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
