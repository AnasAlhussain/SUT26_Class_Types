using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types
{
    public readonly struct Pengar
    {
        public decimal Belopp { get; }
        public string Valuta { get; }


        public Pengar(decimal belopp,string valuta)
        {
            Belopp = belopp;
            Valuta = valuta;
        }


        // return nytt värde i stället för att ändra det gamla

        public Pengar Addera(Pengar annan)
        {
            if(Valuta != annan.Valuta)
            {
                throw new InvalidOperationException("Olika valutor kan inte adderas ....!");
             
            }
            return new Pengar(Belopp + annan.Belopp, Valuta);



        }

    }
}
