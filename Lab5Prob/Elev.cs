using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Prob
{
    /*
     * Elevii vor avea
 nume, prenume
o lista de note specifica fiecarui elev.
O functie care va calcula media elevului
O functie care va returna un string sub forma
nume, prenume
nota0 nota1 nota2…. Notam
    */
    class Elev
    {
        public string Nume;
        public string Prenume;
        public List<int> Note;

        public Elev(string nume, string prenume)
        {
            Nume = nume;
            Prenume = prenume;
            Note = new List<int>();
        }
        public void AdaugaNota(int nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                Note.Add(nota);
            }
            else
            {
                Console.WriteLine("Nota trebuie să fie între 0 și 10.");
            }
        }
        public double CalculeazaMedie()
        {
            if (Note.Count == 0)
            {
                Console.WriteLine("Elevul nu are note.");
                return 0;
            }
            double suma = 0;
            foreach (int nota in Note)
            {
                suma += nota;
            }
            return suma / Note.Count;
        }

    public string ConversieLaSir()
        {
            StringBuilder noteStringBuilder = new StringBuilder();
            foreach (int nota in Note)
            {
                noteStringBuilder.Append(nota);
                noteStringBuilder.Append(", ");
            }
            string noteString = noteStringBuilder.ToString().TrimEnd(' ', ',');

            return $"{Nume}, {Prenume}, Note: {noteString}";
        }
    }
}

