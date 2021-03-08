﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO_Projekt
{
    public class Subject
    {
        /// <summary>
        /// Název předmětu
        /// </summary>
        public string Name { get; set; } 
        /// <summary>
        /// Zkratka názvu předmětu
        /// </summary>
        public string NameShort { get; set; }
        /// <summary>
        /// Počet týdnů které bude předmět trvat
        /// </summary>
        public int NumberOfWeeks { get; set; } 
        /// <summary>
        /// Počet hodin přednášek v jednom týdnu
        /// </summary>
        public int LectureHours { get; set; }
        /// <summary>
        /// Počet hodin cvičení v jednom týdnu
        /// </summary>
        public int PracticeHours { get; set; }
        /// <summary>
        /// Počet hodin seminářů v jednom týdnu
        /// </summary>
        public int SeminarHours { get; set; }
        /// <summary>
        /// Forma ukončení předmětu
        /// </summary>
        public enum FormOfCompletion 
        {
            Z,
            ZK,
            KL
        }
        /// <summary>
        /// Jazyk ve kterém se předmět vyučuje
        /// </summary>
        public enum Language
        {
            CZ,
            EN
        }
        /// <summary>
        /// Velikost třídy, ve které se předmět vyučuje
        /// </summary>
        public int ClassSize { get; set; } 
        /// <summary>
        /// Seznam skupin, které mají tento předmět
        /// </summary>
        public List<Group> GroupList { get; set; }
        /// <summary>
        /// Počet kreditů přiřazených studentovi po úspěšném ukončení předmětu
        /// </summary>
        public int Credits { get; set; }
        /// <summary>
        /// Útvar garantující tento předmět
        /// </summary>
        public enum GuarantorInstitute
        {
            AUIUI,
            AUPKS,
            AUART,
            AUEM
            //atd...
        } 
        /// <summary>
        /// Jméno garanta předmětu
        /// </summary>
        public string GuarantorName { get; set; }
    }
}
