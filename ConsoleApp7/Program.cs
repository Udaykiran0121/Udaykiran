using System;

namespace practice
{
    class program
    {
        static void Main()
        {
            double[] price = { 1799.00,552.00,150.00,821.00 };
            for(int i=0;i<price.Length-1;i++)
            {
                for(int j=0;j<price.Length-i-1;j++)
                {
                    if (price[j] > price[j + 1])
                    {
                        double yes = price[j];
                        price[j] = price[j + 1];
                        price[j + 1] = yes;
                    }
                }
            }
            foreach (double dot in price)

            {
                Console.WriteLine(dot);
            }
        }
    }
}