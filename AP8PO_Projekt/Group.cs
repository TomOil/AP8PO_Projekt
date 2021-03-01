using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt
{
    class Group
    {
        public string Name { get; set; } //Název
        public string NameShort { get; set; } //Zkratka
        public int Grade { get; set; } //Ročník
        public enum Semester  //Semestr
        {
            LS,
            ZS
        }
        public int NumberOfStudents { get; set; } //Počet studentů
        public enum FormOfStudy //Forma studia
        {
            P,
            K
        }
        public enum TypeOfStudy //Typ studia
        {
            Bc,
            Mgr,
            PhD
        }

        public enum Language //Jazyk
        {
            CZ,
            EN
        }
        public List<Subject> SubjectList { get; set; } //Seznam předmětů
    }

    
}
