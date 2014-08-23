using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagementSystem.Models
{
    public class Student
    {
        public int ID { get; set; } //primary key

        [StringLength(50)]
        public string LastName { get; set; }

        [Column("FirstName")]
        [StringLength(50, ErrorMessage="First Name cannot be longer than 50 characters.")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime EnrollmentDate { get; set; }

        //navigation properties 
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}