using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    public abstract class Employee
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = "Unknown"; // null 
                }
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }
        public Employee()
        {

        }
        public abstract double Salary();

        public abstract void Display();
    }
}
