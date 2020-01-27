using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoonMIS4200.Models
{
    public class customer
    {
        public int customerID { get; set; }
        public int customerLastName { get; set; }
        public int customerFirstName { get; set; }
        public int email { get; set; }
        public int phone { get; set; }
        public DateTime customerSince { get; set; }
    }
}