using System;
using System.Collections.Generic;
using System.Text;


namespace Delegate_Vertieferung
{
    public class Buch
    {
        public string Titel { get; set; }
        public string Author { get; set; }
        public int Jahr { get; set; }
        public string ISBN { get; set; }
        public bool Verliehen { get; set; }
        public DateTime AusleiheDatum;
        public DateTime RueckgabeDatum;
        public decimal Preis;

        public Buch(string titel, string author, int jahr, string isbn, decimal preis)
        {
            Titel = titel;
            Author = author;
            Jahr = jahr;
            ISBN = isbn;
            Verliehen = false;
            Preis = preis;
        }


        public override string ToString()
        {
            return $"Titel: {Titel} - Author:{Author} - Jahr: {Jahr}";
        }


        public  bool IstVerliehen()
        {
            return Verliehen;
        }

        



    }

}

