using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat.Carnivore
{
    public class Tiger
    {
        private int id;
        private string name;
        private float weight;

        public Tiger()
        {

        }

        public Tiger(int id, string name, float weight)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                name = value;
            }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
