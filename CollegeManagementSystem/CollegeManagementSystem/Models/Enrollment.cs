using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public enum Grade
    {
        A, B, C, D, F,
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; } //primary keys        
        public int CourseID { get; set; }
        public int StudentID { get; set; } //foreign key
        [DisplayFormat(NullDisplayText="No grade")]
        public Grade? Grade { get; set; } //Grade is Nullable i.e not known. has not been assigned yet

        //navigation properties
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}