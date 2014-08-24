//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CollegeManagementSystem.Models
{
    public class OfficeAssignment
    {
        [Key] //to identify InstructorID as the key since it does not follow the ID or classnameID convention
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name="Office Location")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}