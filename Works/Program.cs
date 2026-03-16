using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Works
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  input = "programing";
            string result = new string(input.Distinct().ToArray());
            Console.WriteLine(result);

        }
    }
}
