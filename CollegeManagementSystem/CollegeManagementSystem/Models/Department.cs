//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CollegeManagementSystem.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName="money")] //the column will be defined using SQL server "money" type in the database
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0: yyy-MM-dd}",ApplyFormatInEditMode=true)]
        [Display(Name="Start Date")]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; } //nullable property. A department may or may not have an administrator

        public virtual Instructor Administrator { get; set; } //the administrator is always an instructor
        public virtual ICollection<Course> Courses { get; set; } //a department may have many courses
         
    }
}
