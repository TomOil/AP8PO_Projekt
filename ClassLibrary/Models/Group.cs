using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt.Models
{
    public class Group
    {
        /// <summary>
        /// Unikátní identifikátor skupiny
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Název skupiny
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Zkratka názvu skupiny
        /// </summary>
        public string NameShort { get; set; }

        /// <summary>
        /// Ročník, ve kterém je skupina
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// Semestr, ve kterém je skupina
        /// </summary>
        public string Semester { get; set; }
    
        /// <summary>
        /// Počet studentů ve skupině
        /// </summary>
        public int NumberOfStudents { get; set; }

        /// <summary>
        /// Forma studia skupiny
        /// </summary>
        public string FormOfStudy { get; set; }

        /// <summary>
        /// Typ studia skupiny
        /// </summary>
        public string TypeOfStudy { get; set; }
        
        /// <summary>
        /// Jazyk, ve kterém se předměty skupiny vyučují
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// List předmětů skupinky
        /// </summary>
        public List<Subject> SubjectList { get; set; }
    }
}
