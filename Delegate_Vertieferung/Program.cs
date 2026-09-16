using static Delegate_Vertieferung.Vertieferung;

namespace Delegate_Vertieferung
{
    public delegate void BuchAktion(Buch buch);

    internal class Program
    {

        public static void Main(string[] args)
        {

            //First();
            Buch();
            Run();

        }



        public static void Buch()
        {
            Buch HarryPotter = new Buch("HarryPotter", "JK Bitch", 1997, "2133-2345-2434-1234-4534", 0.45m);
            Buch HerrDerrRinge = new Buch("Ring Scheiß", "idk", 1995, "2312-3434-2341-6575-3423", 0.46m);
            Buch AnimalFarm = new Buch("Animal Farm", "Orwell", 1945, "6533-2455-6765-8786-6534", 3.00m);
            Buch Cows = new Buch("Cows", "Matthew Stokoe", 1998, "7686-4353-7867-4533-3456", 2.00m);


            Action<Buch> buch = Buch_Methoden.Ausleihen;
            buch += Buch_Methoden.Zuruckgeben;
            buch += Buch_Verwaltung.PreisBerechnung;
            buch += x => Console.WriteLine("BlaBla");

            // Ausführung Dlegeates 
            // --------------------------------- ALL DELEGATES WITH LAMBDA USAGE ---------------------------------


            Func<Buch, int> fbuch = (Buch buch) => buch.RueckgabeDatum.Day - buch.AusleiheDatum.Day;
            fbuch += (Buch buch) => Convert.ToInt32(buch.Preis * (buch.AusleiheDatum.Day - buch.AusleiheDatum.Day));


            //fbuch += (Buch buch) => Convert.ToInt32(buch.ISBN.Substring(0, 2)) + buch.AusleiheDatum.Year;
            var result = fbuch(HarryPotter);


            //methode () because I need the ausführung0 
            Predicate<Buch> pbuch = (Buch buch) => buch.IstVerliehen();
            pbuch += (Buch buch) => int.TryParse(buch.ISBN.Substring(0, 3), out int result);
            //pbuch += (Buch buch) => buch.RueckgabeDatum.Day - buch.AusleiheDatum.Day > 10;


            Comparison<Buch> comparison = (a, b) => a.RueckgabeDatum.Year.CompareTo(b.AusleiheDatum.Year);

            Comparison<Buch> comparison2 = (HarryPotter, HerrDerrRinge) => HarryPotter.Titel.CompareTo(HerrDerrRinge.Titel);

            Comparison<Buch> cbuch = (Buch buch1, Buch buch2) => (buch1.Titel.Equals(buch2.Titel) ? 0 : 1);
            Console.WriteLine(cbuch(HarryPotter, HerrDerrRinge));
            //HarryPotter.Sort((fbuch.RueckgabeDatum.Year, AusleiheDatum )


            // Here we call the first time our methode with the parameter Delegate
            Buch_Verwaltung.Prozess(HarryPotter, buch, fbuch, pbuch);



            // ----------------------------------------------------------------------------------------------------------------

        }

        public static void Run()
        {
            BuchAktion action = Buch_Methoden.BuchDrucken;

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
