using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HoonMIS4200.Models
{
    public class Professor
    {
        [Display(Name = "Professor ID")]
        public int professorID { get; set; }
        [Display(Name = "Professor First")]
        [Required]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Professor Last")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your Ohio email address")]
        public string email { get; set; }

        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicatethat with an ICollection
        [Display(Name = "Course Detail")]
        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}