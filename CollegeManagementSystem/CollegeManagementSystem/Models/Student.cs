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
        //[Required]
        [StringLength(50,MinimumLength=1)] //same as using the Required attribute
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required]  // this can be replaced and minimum length parameter enforced e.g. [Stringlength(50),MinimumLength=1]
        [Display(Name="First Name")]
        [Column("FirstName")] //changed the table name in the database to FirstName but maps to FirstMidName
        [StringLength(50, ErrorMessage="First Name cannot be longer than 50 characters.")]
        public string FirstMidName { get; set; }

        [Display(Name="Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name="Full Name")]
        public string FullName
        {
           get
            {
                return LastName + ", " + FirstMidName;
           }
            
        }

        //navigation properties 
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}