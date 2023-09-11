using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Accounts
    {
        int AccountNo;
        string Name, AccountType;
        public char TransactionType;
        public double Amount, Balance;
       
        public Accounts(int accountNo, string name, string accountType)
        {
            AccountNo = accountNo;
            Name = name;
            AccountType = accountType;
            Balance = 340000;
            //Console.WriteLine($"Account number: {AccountNo}, Name: {Name}, AccountType: {AccountType} ");

        }
        static void Credit(double amount)
        {
            Accounts obj1 = new Accounts(124473, "Amarnath", "Saving Account");
            obj1.Balance += amount;
            Console.WriteLine($"After crediting the amount {amount} the balance in the account is {obj1.Balance}");

        }
        static void Debit(double amount)
        {
            Accounts obj2 = new Accounts(124473, "Amarnath", "Saving Account");
            obj2.Balance -= amount;
            Console.WriteLine($"After debiting the amount {amount} the balance in the account  is {obj2.Balance}");

        }
        public static void ShowData()
        {
            Console.Write("Enter the Account Holder Name:");
            string str1 = Console.ReadLine();
            Console.Write("Enter Account Number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account Type: ");
            string str2 = Console.ReadLine();
            Accounts obj = new Accounts(x, str1, str2);
            Console.Write("Enter the Amount to be Credited or debited: ");
            obj.Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Account number:{obj.AccountNo},  Name:{obj.Name},  AccountType:{obj.AccountType},  Balance:{obj.Balance},  amount:{obj.Amount} ");
            Console.WriteLine("enter the TransactionType D for Deposit and W for Withdrawal");
            obj.TransactionType = Convert.ToChar(Console.ReadLine());
            if (obj.TransactionType == 'D' || obj.TransactionType == 'd')
            {
                Credit(obj.Amount);
            }
            else if(obj.TransactionType == 'W' || obj.TransactionType == 'w')
            {
                Debit(obj.Amount);
            }

        }
    }
}
