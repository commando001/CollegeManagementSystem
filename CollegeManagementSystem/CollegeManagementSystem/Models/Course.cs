//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;

using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagementSystem.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //lets you enter the primary key rather than the database to generate it for you
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}