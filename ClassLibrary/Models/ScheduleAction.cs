using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt.Models
{
    public class ScheduleAction
    {
        /// <summary>
        /// Unikátní identifikátor rozvrhové akce
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Název rozvrhové akce
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Název skupiny, které patří rozvrhová akce
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// Id předmětu rozvrhové akce
        /// </summary>
        public int SubjectId { get; set; }
        /// <summary>
        /// Typ rozvrhové akce
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Počet studentů v rozvrhové akci
        /// </summary>
        public int NumberOfStudents { get; set; }
        /// <summary>
        /// Počet hodin, které ta rozvrhová akce trvá
        /// </summary>
        public int NumberOfHours { get; set; }
        /// <summary>
        /// Počet týdnů, které ta rozvrhová akce trvá
        /// </summary>
        public int NumberOfWeeks { get; set; }
        /// <summary>
        /// Jazyk, ve kterém je ta rozvrhová akce vyučovaná
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// Počet bodů pro zaměstnance za rozvrhovou akci
        /// </summary>
        public float Points { get; set; }
    }
}
