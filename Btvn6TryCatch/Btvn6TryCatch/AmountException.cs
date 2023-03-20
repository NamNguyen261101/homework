using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvn6TryCatch
{
    public class AmountException : Exception
    {
        private double salary;
        private double bonus;
        public AmountException() : base("Salary đang < 60.000 Hoặc Bonus đang > 10.000")
        {

        }

        
    }
}
