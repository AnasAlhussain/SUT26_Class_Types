using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types.PartialDemo
{
    public partial class Order
    {
         partial void OnTotalChange()
        {
            if(Total > 10000)
            {
                Console.WriteLine($" Order {Id} stor Order ! Kräver godkännande !!!");
            }


            
        }
        public string Sammanfattning() => $"Order {Id} : {Total: 0.00} kr";
    }
}
