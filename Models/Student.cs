using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HoonMIS4200.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public int studentID { get; set; }
        
        [Display(Name = "Student First")]
        [Required]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Student Last")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Student Email")]
        [Required]
        public string email { get; set; }
        [Display(Name = "Student Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Student Since")]
        public DateTime studentSince { get; set; }
        [Display(Name = "Course")]
        public ICollection<Course> Course { get; set; }
    }
}