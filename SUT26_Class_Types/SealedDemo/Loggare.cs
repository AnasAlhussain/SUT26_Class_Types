using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types.SealedDemo
{
    internal sealed class Loggare 
    {
        private static readonly Loggare _instans = new();
        private readonly List<string> _logg = new();

        public static Loggare Instans => _instans;
        private Loggare() { } // Ingen utanför klassen kan skriva new loggare ()

        public void Logga(string text)
        {
            string rad = $"[{DateTime.Now:HH:mm:ss}] {text}";
            _logg.Add(rad);
            Console.WriteLine(rad);
        }

        public int AnatlRader => _logg.Count;
    }
}
