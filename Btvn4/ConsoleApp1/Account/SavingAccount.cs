using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    public class SavingAccount : Account
    {
        private long rate = 7/100;
        private double initialize;
        public SavingAccount()
        {

        }

        public SavingAccount(long rate, double initialize) : base(initialize)
        {
            this.rate = rate;
            this.balance = initialize; 
        }

        public long Rate
        {
             get { return this.rate; }
            set { this.rate = value; }
        }

        public double Initialize
        {
            get { return this.initialize; }
            set { this.initialize = value; }
        }

        public double getInterest()
        {
            double newInterestIncome =  rate * initialize;
            return newInterestIncome;
        }


    }
}
