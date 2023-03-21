using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BtvnBai4;

namespace BtvnBai4
{
    internal class Faculty : Employee1
    {
        private int officeHours;
        private int rank; // change to enum

        public Faculty()
        {

        }

        public Faculty(int officeHouser, int rank)
        {

        }
        public int OfficeHours
        {
            get { return officeHours; }
            set { officeHours = value; }
        }

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }

       
        public override double Salary {
            get => salary;
            set 
            {
                _ = (1000 + 0.05) * Salary; 
            } 
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
