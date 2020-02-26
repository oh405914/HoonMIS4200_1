using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HoonMIS4200.Models
{
    public class CourseDetail
    {
        [Display(Name = "Course Detail ID")]
        public int coursedetailID { get; set; }
        [Display(Name = "Course ID")]
        public int courseID { get; set; }
        [Display(Name = "Course")]
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        [Display(Name = "Professor ID")]
        public int professorID { get; set; }
        [Display(Name = "Professor")]
        public virtual Professor Professor { get; set; }
    }
}