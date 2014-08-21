using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;


namespace CollegeManagementSystem.Models
{
    public class Student
    {
        public int ID { get; set; } //primary key
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //navigation properties 
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}