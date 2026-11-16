using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types
{
    internal class Product
    {
        public int ProductId { get; set; }
        public decimal PrisExkMoms { get; set; }
        public string Name { get; set; }
        public int LagarSaldo { get; set; }
        public const decimal Momssats = 0.25m;

        public bool FinnsILager(int antal) => LagarSaldo <= antal;
    }
}
