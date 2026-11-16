using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types.PartialDemo
{
    public partial class Student
    {
        public void Presentera()
        {
            Console.WriteLine($"Hej , Jag heter {Name} och är {Age} år !");
        }
    }
}
