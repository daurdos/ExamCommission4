using Phd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phd.ViewModels
{
    public class StudentGradeViewModel
    {
        public int StudentId { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public string StudentMName { get; set; }
        public string StudentThesisName { get; set; }
        public double AverageGrade { get; set; }
        public string MajorCypher { get; set; } // пока не использую есть баги
        public string MajorName { get; set; } // пока не использую есть баги
        public List<User> Users { get; set; }
        public List<BRStudentGrade> Grades { get; set; }
        public List<UserWithRoles> UserWithRoles { get; set; }

        

    }
}
