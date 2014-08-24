//using System;
//using System.Linq;
//using System.Web;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagementSystem.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //lets you enter the primary key rather than the database to generate it for you
        [Display(Name="Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0,5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; } //loads the DepartmentID from the Department class automatically since its a foreign key

        //navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}