using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class InsuranceVM
    {
        public decimal Quote { get; set; }
        public string FirstName { get; set; }
        public decimal LastName { get; set; }
        public string EmailAddress { get; set; }
        
    }
}