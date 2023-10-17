using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex 1
Catalog
Un catalog contine
 numele clasei
 lista elevilor.
 O functie care va returna un string continand
numele clasei si al fiecarui elev in parte.
 O functie “GetPremiantul” care va determina
elevul cu media cea mai mare.

• Elevii vor avea
 nume, prenume
 o lista de note specifica fiecarui elev.
 O functie care va calcula media elevului
 O functie care va returna un string sub forma
 nume, prenume
 nota0 nota1 nota2…. Notam

• In functia “Main”
 Initializati 3 elevi
 Initializati un catalog adaugandu-I elevii
 Acordati note elevilor
 Apelati metoda GetPremiantul a catalogului si
afisati elevul cu media cea mai mare
 Apelati metoedele care returneaza descrierile
obiectelor si afisati-le rezultatele.

• Realiazti diagrama UML a clasei
• Atentie la : constructori, modificatori de
acces, clase.
            */

            Catalog catalog = new Catalog("Clasa a XII-a");

            // Adaugă elevi în catalog
            Elev elev1 = new Elev("Popescu", "Ion");
            elev1.AdaugaNota(9);
            elev1.AdaugaNota(8);
            elev1.AdaugaNota(7);
            catalog.AdaugaElev(elev1);

            Elev elev2 = new Elev("Ionescu", "Maria");
            elev2.AdaugaNota(10);
            elev2.AdaugaNota(9);
            elev2.AdaugaNota(8);
            catalog.AdaugaElev(elev2);

            Elev elev3 = new Elev("Vitanescu", "Emil");
            elev3.AdaugaNota(7);
            elev3.AdaugaNota(5);
            elev3.AdaugaNota(6);
            catalog.AdaugaElev(elev3);

            // Afiseaza detalii despre catalog si premiant
            Console.WriteLine(catalog.ConversieLaSir());
            Elev premiant = catalog.GetPremiantul();
            if (premiant != null)
            {
                Console.WriteLine($"Premiantul clasei este: {premiant.Nume} {premiant.Prenume} cu media: {premiant.CalculeazaMedie()}");
            }
        }
    }
    }

