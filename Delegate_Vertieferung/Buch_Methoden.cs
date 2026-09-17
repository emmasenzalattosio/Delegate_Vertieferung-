using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Vertieferung
{

    public class Buch_Methoden
    {

        public static void Ausleihen(Buch buch)
        {
            if (!buch.Verliehen)
            {
                buch.Verliehen = true;
                Console.WriteLine("Gimme the ausleihe datum ein!!");
                buch.AusleiheDatum = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine($"Das Buch {buch.Titel} wurde erfolgreich ausgeliehen");
            }

            else
            {
                Console.WriteLine($"Das Buch {buch.Titel} ist bereits verliehen");
            }
        }


        public static void Zuruckgeben(Buch buch)
        {
            if (buch.Verliehen)
            {
                buch.Verliehen = false;

                Console.WriteLine("Gimme the ruckgabe datum ein!!");
                buch.RueckgabeDatum = Convert.ToDateTime(Console.ReadLine());


                Console.WriteLine($"Das Buch {buch.Titel} wurde zucuckgegeben");
            }

            else
            {
                Console.WriteLine($"Das Buch {buch.Titel} wurde nicht zuruckgegeben");
            }
        }

        public static void BuchDrucken(Buch buch)
        {
            Console.WriteLine($"Titel: {buch.Titel} - Author: {buch.Author} - Jahr: {buch.Jahr}");
        }

        public void BerchneAlter(Buch buch)
        {


            int BuchAlt = DateTime.Now.Year - buch.Jahr;
            Console.WriteLine();
            Console.Write($"Das buch {buch.Titel} ist {BuchAlt} alt!!");



        }



    }
}
