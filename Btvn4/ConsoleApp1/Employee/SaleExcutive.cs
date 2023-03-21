using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    class SaleExcutive : Employee
    {
        private int quantityToSell;
        protected double salary;
        public SaleExcutive()
        {

        }

        public int QuantityToSell
        {
            get { return quantityToSell; }
            set { quantityToSell = value; }

        }

        public override double Salary()
        {

            return (quantityToSell * salary) / 7;
        }

        public override void Display()
        {
            Console.WriteLine("Information : ===== ");
        }
        
    }
}
