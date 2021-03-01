using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WorkEmail { get; set; }
        public string PersonalEmail { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string PersonalPhoneNumber { get; set; }
        public bool DoctoralStudent { get; set; }
        public double Load { get; set; }
        public List<ScheduleAction> ScheduleActionList { get; set; }
    }
}
