﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoonMIS4200.Models
{
    public class customer
    {
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }
        public string fullName {
            get { return lastName + ", " + firstName; }
        }
    }
}