using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Car
    {
        private string name;

        public Car() { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public color Color { get; set; }


    }

    public enum color
    {
        Red,
        Green,
        Blue
    }
}
    