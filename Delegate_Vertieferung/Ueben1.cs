using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Vertieferung
{
    public class Vertieferung
    {
        public delegate void SendText(string message);


        public static void ConsoleLogger(string msg) => Console.WriteLine($"Console: {msg}");
        public static void FileLogger(string msg) => Console.WriteLine($"File:  {msg}");
        public static void UserLogger(string msg) => Console.WriteLine($"User  {msg}");


    }


}
