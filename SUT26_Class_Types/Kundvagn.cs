using SUT26_Class_Types.SealedDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types
{
    internal class Kundvagn
    {
        private readonly List<KundvagnRad> _rader = new List<KundvagnRad>();

        public void Laggtill(Product pro , int antal)
        {
            if (!pro.FinnsILager(antal))
            {
                //Loggare.Logga("Kunde inte lägga till {0} : för få i lager", pro.Name);
                //return;
            }
        }

        private static SealedDemo.Loggare Loggare => SealedDemo.Loggare.Instans;

    }


    public readonly struct KundvagnRad
    {
        public int Antal { get; }
    }

   
}
