using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;

using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class Student
    {
        public int ID { get; set; } //primary key
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime EnrollmentDate { get; set; }

        //navigation properties 
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}