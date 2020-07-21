using System;
using System.Collections.Generic;
using Vjezba1_Zad3.Classes;
using Vjezba1_Zad3.Enums;

namespace Vjezba1_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<BankAccount>();
            accounts.Add(new BankAccount { AccountNumber = "12341234", Balance = 0.00, AccountType = AccountType.CurrentAccount });
            accounts.Add(new BankAccount { AccountNumber = "11112222", Balance = 1000.00, AccountType = AccountType.GiroAccount });
            accounts.Add(new BankAccount { AccountNumber = "32103210", Balance = 12330.00, AccountType = AccountType.Savings });
            accounts.Add(new BankAccount { AccountNumber = "32404410", Balance = 12.00, AccountType = AccountType.GiroAccount });
            accounts.Add(new BankAccount { AccountNumber = "12103310", Balance = 213123.23, AccountType = AccountType.CurrentAccount });

            var chosenOption = new string("");
            while (true)
            {
                Console.WriteLine("Hello! What would you like to do?");
                Console.WriteLine("Press 1 to add new account");
                Console.WriteLine("Press 2 to print all accounts");
                Console.WriteLine("Press 3 to exit");

                chosenOption = Console.ReadLine();

                if (chosenOption != "1" && chosenOption != "2" && chosenOption != "3")
                    Console.WriteLine("Invalid input!");
                else if(chosenOption == "3")
                    break;
                else if (chosenOption != "2")
                {
                    Console.WriteLine("Enter account number for new account:");
                    var accountNumber = Console.ReadLine();
                    Console.WriteLine("Enter balance for new account:");
                    var balance = new double();
                    if (!double.TryParse(Console.ReadLine(), out balance))
                    {
                        Console.WriteLine("Invalid balance!");
                        break;
                    }
                    Console.WriteLine("Enter account type: (1)Savings (2)CurrentAccount (3)GiroAccount");
                    var accountTypeAsString = Console.ReadLine();

                    if (!int.TryParse(accountTypeAsString, out var accountType) ||
                        (accountTypeAsString != "1" && accountTypeAsString != "2" && accountTypeAsString != "3"))
                    {
                        Console.WriteLine("Invalid account type!");
                        break;
                    }
                    
                    accounts.Add(new BankAccount(accountNumber, balance, (AccountType)accountType));
                    Console.WriteLine("Account added!");
                }
                else if (chosenOption != "1")
                {
                    foreach (var account in accounts)
                    {
                        Console.WriteLine(account);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
