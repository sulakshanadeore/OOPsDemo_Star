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

    public class SavingsAccount : BankAccount
    { 
    private decimal InterestRate { get; set; }

        public SavingsAccount(string acholdername, decimal bal,decimal interestrate):base(acholdername,bal)
        {
            InterestRate = interestrate;    
            
        }
        public override string DisplayBalance(out decimal bal)
        {
            Console.WriteLine(InterestRate);
            string s=base.DisplayBalance(out bal);
            return s;
        
        
        }

    }

}
