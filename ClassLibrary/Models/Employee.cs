using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt.Models
{
    public class Employee
    {
        /// <summary>
        /// Unikátní identifikátor zaměstnance
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Křestní jméno zaměstnance
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Příjmení zaměstnance
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Pracovní email zaměstnance
        /// </summary>
        public string WorkEmail { get; set; }
        /// <summary>
        /// Osobní email zaměstnance
        /// </summary>
        public string PersonalEmail { get; set; }
        /// <summary>
        /// Pracovní telefonní číslo zaměstnance
        /// </summary>
        public string WorkPhoneNumber { get; set; }
        /// <summary>
        /// Osobní telefoní číslo zaměstnance
        /// </summary>
        public string PersonalPhoneNumber { get; set; }
        /// <summary>
        /// True jestli je zaměstnanec zároveň doktorantem
        /// </summary>
        public bool DoctoralStudent { get; set; }
        /// <summary>
        /// Úvazek zaměstnance (hodnota mezi 0.0 a 1.0)
        /// </summary>
        public double EmployeeLoad { get; set; }
        /// <summary>
        /// List rozvrhových akci toho určitého zaměstnance
        /// </summary>
        public List<ScheduleAction> ScheduleActionList { get; set; }
    }
}
