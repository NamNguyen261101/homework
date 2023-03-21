using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BtvnBai4;

namespace BtvnBai4
{
    class Worker : Employee
    {
        private int quantityToSell;
        protected double salary;
        public Worker()
        {

        }

        public int QuantityToSell
        {
            get { return quantityToSell; }
            set { quantityToSell = value; }

        }
        public override void Display()
        {
            Console.WriteLine("Information : ===== ");

        }

        public override double Salary()
        {
            return quantityToSell * salary / 7;
        }
    }
}
