using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    public class Account
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        protected double balance;

        public int Id
        {
            get { return id++; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                
                if (!string.IsNullOrEmpty(value)) {
                    firstName = value;
                } else
                {
                    firstName = "Unknown";
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set 
            {
                if (!string.IsNullOrEmpty(value)) {
                    lastName = value;
                }
                else
                {
                    lastName = "Unknown";
                }
            }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double Balance
        {
            get { return balance; }
                        set
            {
                balance = value;
            }
        }

        public  Account()
        {

        }

        public Account(double initialize)
        {
            balance = initialize;
        }
        public Account (int id, string firstName, string lastName, string email, double balance)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.balance = balance;
        }

        public virtual double Deposite(double balance, double moneyGiveIn )
        {
           /* Console.WriteLine("Deposite money");
            moneyGiveIn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{moneyGiveIn}");*/
            this.balance =  moneyGiveIn + balance;
            return this.balance; 
        }

        public virtual double WithDraw(double balance, double moneyTakeOut)
        {
            /*Console.WriteLine("With draw money ");
            moneyTakeOut = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{moneyTakeOut}");*/
            if (moneyTakeOut > balance)
            {
                Console.WriteLine("Can't access to withdraw money ");
            } else
            {
                this.balance = (double) balance - moneyTakeOut;
            }
            
            return this.balance;
        }

        public double GetBalance(double balane)
        {
            return this.balance;
        }


    }
}
