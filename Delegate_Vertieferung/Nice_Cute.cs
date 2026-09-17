using System;
using System.Collections.Generic;
using System.Text;
using static Delegate_Vertieferung.Buch_Verwaltung;

namespace Delegate_Vertieferung
{
    public class Nice_Cute
    {

        public void ChooseOldBook()
        {
            Console.WriteLine("Which book do you wanna see the info of`??");
            Console.WriteLine("[1] HarryPotter");
            Console.WriteLine("[2] Ring Scheiß");
            Console.WriteLine("[3] Animal Farm");
            Console.WriteLine("[4] Cows");

            char choose = Console.ReadKey().KeyChar;



            if (choose == '1')
            {

                Action<Buch> buchy = Buch_Methoden.Ausleihen;
                buchy += Buch_Methoden.Zuruckgeben;

                Action<Buch> buchu = Buch_Verwaltung

            }

            else if (choose == '2')
            {

            }
            else if (choose == '3')
            {

            }
            else if (choose == '4')
            {


            else
            {
                Console.WriteLine("We don´t have other books, srry not srry");
            }


        }
    }
}
