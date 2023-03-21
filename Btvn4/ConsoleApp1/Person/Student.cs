using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    public class Student : Employee1
    {
        private string enrolled;

        public string Enrolled
        {
            get { return enrolled; }
            set { enrolled = value; }
        }

        public override double Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double CalculateBonus()
        {
            throw new NotImplementedException();
        }

        public override double CalculateVacation()
        {
            throw new NotImplementedException();
        }
    }

    enum enrolled
    {
        None,
        Business,
        ComputerScience,
        Chef,
        Player
    }
}
