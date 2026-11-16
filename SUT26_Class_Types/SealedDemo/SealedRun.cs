using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types.SealedDemo
{
    internal class SealedRun
    {
        public static void Run()
        {
            Console.WriteLine("------- Loggare _singelton ------");

            Loggare.Instans.Logga("Användare Loggade in ");
            Loggare.Instans.Logga("Användare Öppnade kundvagnen  ");
            Console.WriteLine($"Samma insatns  {ReferenceEquals(Loggare.Instans,Loggare.Instans)}");

        }
    }
}
