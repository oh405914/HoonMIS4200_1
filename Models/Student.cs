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
        public string firstName { get; set; }
        [Display(Name = "Student Last")]
        public string lastName { get; set; }
        [Display(Name = "Student Email")]
        public string email { get; set; }
        [Display(Name = "Student Phone")]
        public string phone { get; set; }
        [Display(Name = "Student Since")]
        public DateTime studentSince { get; set; }
        [Display(Name = "Course")]
        public ICollection<Course> Course { get; set; }
    }
}