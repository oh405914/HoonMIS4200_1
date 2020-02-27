using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HoonMIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        [Display (Name ="Course Description")]
        public string description { get; set; }
        [Display(Name = "Course Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyy}", ApplyFormatInEditMode =true)]
        public DateTime courseDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        [Display(Name = "Course Details")]
        public ICollection<CourseDetail> CourseDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        [Display(Name = "Student ID")]
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}