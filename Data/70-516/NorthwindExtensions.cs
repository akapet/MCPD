using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _70_516
{
    public partial class Order_Detail
    {
        public double DetailTotal
        {
            get
            {
                return (1 - Discount) * (double)(Quantity * UnitPrice);
            }
        }

        partial void OnQuantityChanging(Int16 value)
        {
            Debug.WriteLine(string.Format("Changing quantity from {0} to {1}", Quantity, value));
        }

        partial void OnQuantityChanged()
        {
            Debug.WriteLine(string.Format("Changed quantity to {0}", Quantity));
        }
    }
}
