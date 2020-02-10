using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoonMIS4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        public int professorID { get; set; }
        public virtual Professor Professor { get; set; }
    }
}