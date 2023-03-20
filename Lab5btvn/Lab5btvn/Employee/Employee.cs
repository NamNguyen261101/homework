using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn5
{
    public class Employee
    {
        private static int id;
        private string name;
        private int age;

        public Employee() 
        { 
              
        }

        public Employee(int id, string name, int age)
        {
            id = id++;
            this.name = name;
            this.age = age;
        }

        public Employee(string name, int age)
        {
            id++;
            this.name = name;
            this.age = age;
        }

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string Name 
        { 
            get { return name; } 
            private set { name = value; } 
        }

        public int Age
        {
            get { return age; }
            private set
            {
                age = value;
            }
        }

        public void SetName(string name)
        {
            //this.name = name;
            TextInfo txtInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
            this.name = txtInfo.ToTitleCase(name);
        }

        public void SetAge(int age)
        {
            this.age = age;
        }


    }
}
