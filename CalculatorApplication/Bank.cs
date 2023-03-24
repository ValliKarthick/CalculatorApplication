using System;

namespace CalculatorApplication
{
    public abstract class Bank
    {
        //int availableBalance;
        //int amountToDeposit;
        //public abstract int AvailableBalance();
        public int DepositAmount()
        {
             return 4000;
            //Console.WriteLine("Amount after Depositing = ", availableBalance + amountToDeposit);
        }

        public void WithdrawAmount()
        {
            int availableBalance = 100000;
            int amountToWithdraw = 4000;
            Console.WriteLine("Amount after Withdrawing = ", availableBalance + amountToWithdraw);
        }
    }
}
