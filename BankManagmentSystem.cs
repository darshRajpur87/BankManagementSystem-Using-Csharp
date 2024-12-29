using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;

namespace CsharpLearning
{
    internal class BankManagementSystem
    {
        private int AccountNumber;
        private int NetAmount;
        private string AccountHolderName;
        private int AccountHolderAge;

        public void Deposit()
        {
            Console.WriteLine("Enter Account Number : ");
             int Accountid = Convert.ToInt32(Console.ReadLine());
            if (Accountid == AccountNumber)
            {
                Console.WriteLine("Enter the Amount you want Deposit : ");
                int Ammount = Convert.ToInt32(Console.ReadLine());
                NetAmount = NetAmount + Ammount;
                Console.WriteLine($"Account Balance : {NetAmount}");
            }
            else
            {
                Console.WriteLine("Invalid Account Number !!!");
            }
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter Account Number : ");
            int Accountid = Convert.ToInt32(Console.ReadLine());
            if (Accountid == AccountNumber)
            {
                Console.WriteLine("Enter the Amount you want Withdraw : ");
                int Ammount = Convert.ToInt32(Console.ReadLine());
                NetAmount = NetAmount - Ammount;
                Console.WriteLine($"Account Balance : {NetAmount}");
            }

        }
        public void OpenAccount()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AccountDetail.txt");

            Console.WriteLine("Enter Your Account holder's name : ");
             AccountHolderName = Console.ReadLine();
            Console.WriteLine("Enter the Age of Account Holder :  ");
            AccountHolderAge = Convert.ToInt32(Console.ReadLine());
            if (AccountHolderAge < 18)
            {
                Console.WriteLine($"{AccountHolderName} sorry you are minnor . Visit After your age reaches to 18.");
            }
            Random ran = new Random();
            AccountNumber = ran.Next(100000000, 999999999);
            Console.WriteLine("Your Account is Successfully Created : ");
            Console.WriteLine($"Account Holder      : " + AccountHolderName);
            Console.WriteLine($"Account Holder Age  : " + AccountHolderAge);
            Console.WriteLine($"Account Number      : " + AccountNumber);
        }

        public void ShowAccount()
        {
            Console.WriteLine("Enter the Account Number :");
            int Accountid = Convert.ToInt32(Console.ReadLine());
            if (Accountid == AccountNumber)
            {
                Console.WriteLine($"Account Holder      : " + AccountHolderName);
                Console.WriteLine($"Account Holder Age  : " + AccountHolderAge);
                Console.WriteLine($"Account Number      : " + AccountNumber);
                Console.WriteLine($"Account Balance     : {NetAmount}");
            }
            else
            {
                Console.WriteLine("Invalid Account Number !");
            }
        }


        static int Main(string[] args)
        {
            BankManagementSystem bankSystem = new BankManagementSystem();
            int choice;
            do
            {
                Console.WriteLine("Please Select Your Query! ");
                Console.WriteLine("1.Open New Account");
                Console.WriteLine("2.Deposit Money");
                Console.WriteLine("3.Withdraw Money");
                Console.WriteLine("4.Show Accouont Detail");
                Console.WriteLine("5.Terminate Transaction");
                Console.WriteLine("Enter Your Query Choice : ");
               
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            bankSystem.OpenAccount();
                            Console.WriteLine("");
                            break;
                        }
                    case 2:
                        {
                            bankSystem.Deposit();
                            Console.WriteLine("");
                            break;
                        }
                    case 3:
                        {
                            bankSystem.Withdraw();
                            Console.WriteLine("");
                            break;
                        }
                    case 4:
                        {
                            bankSystem.ShowAccount();
                            Console.WriteLine("");
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                }
            } while (choice != 'y');
            return 0;
        }
    }
}
