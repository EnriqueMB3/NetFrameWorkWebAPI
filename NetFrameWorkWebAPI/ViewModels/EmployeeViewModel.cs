using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFrameWorkWebAPI.ViewModels
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}