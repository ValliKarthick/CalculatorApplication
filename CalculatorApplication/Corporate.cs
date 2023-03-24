using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class Corporate : Bank, ICorporate
    {
        Corporate corporate = new Corporate();

        public int GetAccountNumber()
        {
            throw new NotImplementedException();
        }

        public string GetBankDetails(int accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
