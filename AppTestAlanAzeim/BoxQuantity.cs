using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestAlanAzeim
{
    internal class BoxQuantity
    {
        protected int Quantity;

        public int Value
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        //cosnturctors
        public BoxQuantity()
        {
            Value = 0;
        }
        public BoxQuantity(CheckBox quanquity1)
        {
            Value = 1;
        }
        public BoxQuantity(CheckBox quanquity1, CheckBox quantity2)
        {
            Value = 2;
        }

        public override string ToString()
        {
            return Convert.ToString(Value);
        }
    }
}
