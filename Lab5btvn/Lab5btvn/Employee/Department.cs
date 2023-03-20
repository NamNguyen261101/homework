using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace btvn5
{
    public class Department
    {
        private static int id;
        private string name;
        private Employee[] employees;

        public Department()
        {

        }
        public Department(string name, int a)
        {
            id++;
            this.name = name;
            employees = new Employee[a];
        }

        public int Id
        {
            get { return id; }
            private set { id = value; }

        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                    
                name = value;
            }
        }

        public Employee this[int index]

        {
            get {
                if (index < 0 || index > employees.Length - 1)
                {
                    return null;
                }


                return employees[index];
            }

            set
            {
               if (index < 0 || index > employees.Length - 1 )
                {
                    throw new ArgumentOutOfRangeException();
                }

                employees[index] = value;
            }

        }

        public Employee this[string name]
        {
            get
            {
                foreach (Employee employee in employees)
                {
                    if (employee.Name == name)
                    {
                        return employee;
                    }
                }
                return null;
            }
        }

        public override string ToString()
        {
            return "Department:  " + Name + " " + employees ;
        }




    }
}
