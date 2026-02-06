using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pintry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  correctpin = "1234";
            int attempts = 0;
            while (attempts < 3)
            {
                Console.WriteLine("enter your pin code");
                string pin =(Console.ReadLine());
                if(pin==correctpin)
                {
                    Console.WriteLine("Pin is correct. you are smart");
                    return;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("use your brain not hand");
                    Console.WriteLine("pin is incorrect, you have {0} tries left", 3-attempts);

                }


            }
        }
    }
}
