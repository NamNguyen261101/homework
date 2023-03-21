using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    public abstract class Employee1 : Person
    {
        private string department;
        protected double salary;
        private DateOnly dataHired;

        public Employee1()
        {

        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public abstract double Salary
        {
            get;
            set;
        }

        public DateOnly DataHired
        {
            get { return dataHired; }
            set { dataHired = value; }
        }

        public override double CalculateBonus()
        {
            throw new NotImplementedException();
            
        }

        public override double CalculateVacation()
        {
            throw new NotImplementedException();
        }
    }

}
