using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types.PartialDemo
{
    internal static class PartialExempel
    {

      public static void Run()
        {
            Console.WriteLine("----- Partial class : Student ------");
            var student = new Student { Name = "Sara", Age = 30 };
            student.Presentera();


            Console.WriteLine("-------- Order Class : Genererad kod ------------");
            var liten = new Order { Id = 1, Total = 500 };
            var stor = new Order { Id = 2, Total = 25000 };  
            Console.WriteLine(liten.Sammanfattning());
            Console.WriteLine(stor.Sammanfattning());
        }
    }
}
