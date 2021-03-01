using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt
{
    class Subject
    {
        public string Name { get; set; } //Nazev
        public string NameShort { get; set; } //Zkratka
        public int NumberOfWeeks { get; set; } //Počet týdnů
        public int LectureHours { get; set; } //Hodiny přednášek
        public int PracticeHours { get; set; } //Hodiny cvičení
        public int SeminarHours { get; set; } //Hodiny seminářů
        public enum FormOfCompletion //Forma zakončení
        {
            Z,
            ZK
        }
        public enum Language //Jazyk
        {
            CZ,
            EN
        }
        public int ClassSize { get; set; } //Velikost třídy
        public List<Group> GroupList { get; set; } //Seznam skupin
        public int Credits { get; set; } //Počet kreditů
        public enum GuarantorInstitute //Garantující ústav
        {
            AUIUI,
            AUPKS,
            AUART,
            AUEM
            //atd...
        } 
        public string GuarantorName { get; set; }
    }
}
