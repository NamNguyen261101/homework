using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    public class CheckAccount : Account
    {
        private double feeTransfer = 0.5;

        public double FeeTransfer
        {
            get { return feeTransfer; }
            set { feeTransfer = value; }
        }
        public CheckAccount()
        {

        }

        public CheckAccount(double balance, double feeTransfer)
        {
            this.balance = balance;
            this.feeTransfer = feeTransfer;
        }

        public override double Deposite(double balance, double moneyGiveIn)
        {
            this.balance = moneyGiveIn + balance - feeTransfer;
            return this.balance;
        }

        public override double WithDraw(double balance, double moneyTakeOut)
        {
            if (moneyTakeOut > balance)
            {
                Console.WriteLine("Can't access to withdraw money ");
            }
            else
            {
                this.balance = balance - moneyTakeOut - feeTransfer ;
            }

            return balance;
        }

    }
}
