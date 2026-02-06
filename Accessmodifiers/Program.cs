using Accessmodifiers;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessmodifiers
{ /*
  * wap bank class ,accno,customer name,amount,bankname,bankifsc,bankloc, create account 
  * deposit amount,withdraw amount
  */

    class bank
    {
        int accno;
        string accname;
        double bal;
        static string bankname;
        static int bankifsc;
        static string bankloc;
    static bank()
        {
            bankname = "SBI";
            bankifsc = 1234;
            bankloc = "nakrekal";

        }
        internal bank(int accno, string accanme)
        {
            this.accno = accno;
            this.accname = accanme;

        }
        internal static void bankdetails()
        {
            Console.WriteLine("bank name is :" + bankname);
            Console.WriteLine("bank IFSC code is :" + bankifsc);
            Console.WriteLine("bank location is:" + bankloc);
        }
        internal void createaccont(double amt)
        {
            bal += amt;
            Console.WriteLine("your account is created successfully");
            Console.WriteLine("your account details are:");
            Console.WriteLine("account holder name is:" + accname);
            Console.WriteLine("account number is :" + accno);
            Console.WriteLine("account balance is :" + bal);
        }
        internal void depositamount(double amt)
        {
            bal += amt;
            Console.WriteLine("your balance amount is :" + bal);
        }
        internal void withdrawamount(double amt)
        {
            if (amt < bal)
            {
                bal = bal - amt;
                Console.WriteLine("your updated balance is :" + bal);
            }
            else
            {
                Console.WriteLine("error: insufficent balance");
            }
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
        bank obj = new bank(1234, "uday kiran");
        obj.createaccont(10000);
        obj.depositamount(20000);
        obj.withdrawamount(5000);
        }
    }


