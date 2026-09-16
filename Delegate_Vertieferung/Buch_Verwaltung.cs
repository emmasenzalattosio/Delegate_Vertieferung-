using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Vertieferung
{
    public class Buch_Verwaltung // Verwaltung = administration
    {


        public static void Prozess(Buch buch, Action<Buch> action, Func<Buch, int> func, Predicate<Buch> predi)
        {
            action(buch);
            int result = func(buch);
            Console.WriteLine($"Ausleihte nummer ist: {result}");

            Console.WriteLine($"Komm das buch aus Deutschland?? {predi(buch)}");
            
        }


        public static void PreisBerechnung(Buch buch)
        {
            if (buch.Verliehen)
            {
                TimeSpan ausleihedauer = buch.RueckgabeDatum - buch.AusleiheDatum;

                decimal gesamtpreis = (decimal)ausleihedauer.TotalDays * buch.Preis;
                Console.WriteLine($"Der Gesamtpreis für das Buch '{buch.Titel}' beträgt: {gesamtpreis:C}' für {ausleihedauer.TotalDays} Tage.");

            }
        }


    }
}
