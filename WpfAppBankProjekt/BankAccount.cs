using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBankProjekt
{
    public class BankAccount
    {
        public string IBAN { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string iban, string accountName, decimal initialBalance)
        {
            IBAN = iban;
            Balance = initialBalance;
            AccountName = accountName;
        }

        // Geld einzahlen
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        // Geld abheben
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
