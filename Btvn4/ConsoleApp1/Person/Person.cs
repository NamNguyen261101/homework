using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    public abstract class Person
    {
        private long id;
        private string name;
        private uint phoneNumber;
        private string email;
        private string address;

        public long Id
        {
            get { return id++; }
            set { id = value; }
        }

        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        public uint PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
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
        // 1
        public override string ToString()
        {
            return "Person: " + Name + " " + Email;
        }
        double bonus;
        public abstract double CalculateBonus();


        public abstract double CalculateVacation();
    }
}
