using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvnless3
{
    public class Employee
    {
        private int id=0;
        private string name;
        private DateTime yearOfBirth;
        private double salaryLevel;
        private double basicSalary;

        // properties
        public int Id
        {
            get { return id++; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime YearOfBirth
        {
            get { return yearOfBirth; }
            set { yearOfBirth = value; }
        }

        public double SalaryLevel
        {
            get { return salaryLevel; }
            set { salaryLevel = value; }
        }


        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        // Constructor
        public Employee()
        {

        }

        public Employee(int id, string name, DateTime yearOfBirth, double salaryLevel, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicSalary;
        }

        public double GetInCome(double salaryLevel, double basicSalary)
        {
            return (double) salaryLevel * basicSalary;
        }

        public void Input()
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();
            Console.Write("Nhap bac luong: ");
            SalaryLevel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so luong: ");
            BasicSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {

            Console.WriteLine("Ten hien thi");
            Console.WriteLine(id + name + salaryLevel + basicSalary) ;
        }

    }
}
