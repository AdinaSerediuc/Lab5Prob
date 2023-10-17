using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Prob
{
    /*
     * Catalog
Un catalog contine
 numele clasei
 lista elevilor.
 O functie care va returna un string continand
numele clasei si al fiecarui elev in parte.
 O functie “GetPremiantul” care va determina
elevul cu media cea mai mare.
    */
    class Catalog
    {
        private string NumeClasa;
        private List<Elev> Elevi;

        // Constructor
        public Catalog(string numeClasa)
        {
            NumeClasa = numeClasa;
            Elevi = new List<Elev>();
        }

        // Adaugă un elev în catalog
        public void AdaugaElev(Elev elev)
        {
            Elevi.Add(elev);
        }

        // Returnează un șir cu numele clasei și al fiecărui elev în parte
        public string ConversieLaSir()
        {
            string rezultat = $"Clasa: {NumeClasa}\n";
            foreach (Elev elev in Elevi)
            {
                rezultat += elev.ConversieLaSir() + "\n";
            }
            return rezultat;
        }

        // Returnează elevul cu media cea mai mare
        public Elev GetPremiantul()
        {
            if (Elevi.Count == 0)
            {
                Console.WriteLine("Nu există elevi în catalog.");
                return null;
            }

            Elev premiant = Elevi[0];
            foreach (Elev elev in Elevi)
            {
                if (elev.CalculeazaMedie() > premiant.CalculeazaMedie())
                {
                    premiant = elev;
                }
            }

            return premiant;
        }
    }
}

