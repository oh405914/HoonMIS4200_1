using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoonMIS4200.Models
{
    public class Professor
    {
        public int professorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}