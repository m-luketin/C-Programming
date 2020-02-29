using System;
using System.Collections.Generic;
using System.Text;
using Vjezba1_Zad3.Enums;

namespace Vjezba1_Zad3.Classes
{
    public class BankAccount
    {
        public BankAccount()
        {}

        public BankAccount(string accountNumber, double balance, AccountType accountType)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            AccountType = accountType;
        }

        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public AccountType AccountType { get; set; }

        public override string ToString()
        {
            return "\nAccount number: " + AccountNumber 
                                      + "\nBalance:        " + Balance 
                                      + "\nAccount type:   " + AccountType;
        }
    }
}
