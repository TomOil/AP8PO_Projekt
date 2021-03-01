using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt
{
    class ScheduleAction
    {
        public string Title { get; set; }
        public Employee Employee { get; set; }
        public Subject Subject { get; set; }
        public enum Type
        {
            Lecture,
            Seminar,
            Practice,
            Credit,
            ClassifiedCredit,
            Exam
        }
        public int NumberOfStudents { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfWeeks { get; set; }
        public enum Language
        {
            CZ,
            EN
        }
    }
}
