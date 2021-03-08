using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt
{
    public class ScheduleAction
    {
        /// <summary>
        /// Název rozvrhové akce
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Zaměstnanec, který tu rozvrhovou akci vyučuje
        /// </summary>
        public Employee Employee { get; set; }
        /// <summary>
        /// Předmět, který ten určitý zaměstnanec vyučuje v té rozvrhové akci(štítku)
        /// </summary>
        public Subject Subject { get; set; }
        /// <summary>
        /// Typ rozvrhové akce
        /// </summary>
        public enum Type
        {
            Lecture,
            Seminar,
            Practice,
            Credit,
            ClassifiedCredit,
            Exam
        }
        /// <summary>
        /// Počet studentů v rozvrhové akci
        /// </summary>
        public int NumberOfStudents { get; set; }
        /// <summary>
        /// Počet hodin, které ta rozvrhová akce trvá
        /// </summary>
        public int NumberOfHours { get; set; }
        /// <summary>
        /// počet týdný, které ta rozvrhová akce trvá
        /// </summary>
        public int NumberOfWeeks { get; set; }
        /// <summary>
        /// Jazyk, ve kterém je ta rozvrhová akce vyučovaná
        /// </summary>
        public enum Language
        {
            CZ,
            EN
        }
    }
}
