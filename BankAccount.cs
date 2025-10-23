using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    public class BankAccount
    {
        private string AccountHolderName { get; set; }
        private decimal Balance { get; set; }

        public BankAccount(string acholdername,decimal bal)
        {
                AccountHolderName = acholdername;   
                Balance = bal;
        }

        public  virtual string DisplayBalance(out decimal bal)
        {
            //return string.Concat(AccountHolderName, Balance);
            bal = Balance;
            return AccountHolderName;
        }
    }
}
