using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Zad1
{
    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int NrAlbumu { get; set; }
        public string wydzial { get; set; }

        public Student(string imie, string nazwisko, int NrAlbumu, string wydzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.NrAlbumu = NrAlbumu;
            this.wydzial = wydzial;
        }

        public Student()
            : this("", "", 0, "")
        { }
    }
}
