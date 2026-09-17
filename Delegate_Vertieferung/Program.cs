using static Delegate_Vertieferung.Vertieferung;

namespace Delegate_Vertieferung
{
    public delegate void BuchAktion(Buch buch);
    public delegate int BuchAlterBerechnung(Buch buch);

    internal class Program
    {

        public static void Main(string[] args)
        {

            //First();
            Buch();


        }


        public static void Buch()
        {
            //Action<Buch> buch = Buch_Methoden.Ausleihen;
            //buch += x => Console.WriteLine("BlaBla");
            Nice_Cute cute = new Nice_Cute();
            cute.ChooseOldBook();

            // Ausführung Dlegeates 
            // --------------------------------- ALL DELEGATES WITH LAMBDA USAGE ---------------------------------


            Func<Buch, int> fbuch = (Buch buch) => buch.RueckgabeDatum.Day - buch.AusleiheDatum.Day;
            fbuch += (Buch buch) => Convert.ToInt32(buch.Preis * (buch.AusleiheDatum.Day - buch.AusleiheDatum.Day));


            //fbuch += (Buch buch) => Convert.ToInt32(buch.ISBN.Substring(0, 2)) + buch.AusleiheDatum.Year;
            var result = fbuch(Books_List.HarryPotter);


            //methode () because I need the ausführung0 
            Predicate<Buch> pbuch = (Buch buch) => buch.IstVerliehen();
            pbuch += (Buch buch) => int.TryParse(buch.ISBN.Substring(0, 3), out int result);
            //pbuch += (Buch buch) => buch.RueckgabeDatum.Day - buch.AusleiheDatum.Day > 10;


            Comparison<Buch> comparison = (a, b) => a.RueckgabeDatum.Year.CompareTo(b.AusleiheDatum.Year);

            Comparison<Buch> comparison2 = (HarryPotter, HerrDerrRinge) => HarryPotter.Titel.CompareTo(HerrDerrRinge.Titel);

            Comparison<Buch> cbuch = (Buch buch1, Buch buch2) => (buch1.Titel.Equals(buch2.Titel) ? 0 : 1);
            Console.WriteLine(cbuch(Books_List.HarryPotter, Books_List.HerrDerrRinge));
            //HarryPotter.Sort((fbuch.RueckgabeDatum.Year, AusleiheDatum )


            // Here we call the first time our methode with the parameter Delegate
            Buch_Verwaltung.Prozess(Books_List.HarryPotter, buch, fbuch, pbuch);



            // ----------------------------------------------------------------------------------------------------------------

        }






        public static void First()
        {
            SendText logger = ConsoleLogger;
            logger("User Logged in");

            logger = FileLogger;
            logger("Database error");


            // ----------------------------------------------------------------------------------------------------------------

            SendText multilogger = ConsoleLogger;
            multilogger += FileLogger;

            multilogger("Alert!!");

            // --------------------------------------------------------------------------------------------------------------------

        }
    }
}
