using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvn6TryCatch
{
    public class Lecture
    {
        private string name;
        private double salary;
        private double bonus;

        public Lecture() 
        {

        }

        public Lecture(string name, double salary, double bonus)
        {
            this.name = name;
            this.salary = salary;
            this.bonus = bonus;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set 
            {
                try
                {
                    if (salary > 60000)
                    {
                        throw new AmountException();
                    }
                    
                }

                catch (AmountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    if (salary < 60000)
                    {
                        salary = value;
                    }
                }
            }
        }

        public double Bonus
        {
            get { return bonus; }
            set
            {
                try
                {
                    if (bonus > 10000)
                    {
                        throw new AmountException();
                    }

                }

                catch (AmountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    if (bonus < 10000)
                    {
                        bonus = value;
                    }
                }
            }
        }

        

    }
}
