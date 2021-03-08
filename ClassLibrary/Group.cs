using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt
{
    public class Group
    {
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
        public enum Semester 
        {
            LS,
            ZS
        }
        /// <summary>
        /// Počet studentů ve skupině
        /// </summary>
        public int NumberOfStudents { get; set; }
        /// <summary>
        /// Forma studia skupiny
        /// </summary>
        public enum FormOfStudy 
        {
            P,
            K
        }
        /// <summary>
        /// Typ studia skupiny
        /// </summary>
        public enum TypeOfStudy
        {
            Bc,
            Mgr,
            PhD
        }
        /// <summary>
        /// Jazyk, ve kterém se předměty skupiny vyučují
        /// </summary>
        public enum Language 
        {
            CZ,
            EN
        }
        /// <summary>
        /// List předmětů skupinky
        /// </summary>
        public List<Subject> SubjectList { get; set; }
    }

    
}
