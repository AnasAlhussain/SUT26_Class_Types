using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_Types.PartialDemo
{
    public partial class Order
    {
        private decimal _total;

        public int Id {  get; set; }

        public decimal Total
        {
            get => _total;
            set
            {
                _total = value;
                OnTotalChange();
            }
        }

        partial void OnTotalChange();
    }
}
