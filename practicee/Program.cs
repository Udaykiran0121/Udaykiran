using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace practicee
{
    public class program
    {
        static void Main()
        {
            /*--->reverse string*/
            /*string input = "yes you can do it";
            string result = ReverseString(input);
            Console.WriteLine(result);
            
        }
        static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
            
             Console.WriteLine("enter a string");
            string input = Console.ReadLine();
            string result = ReverseString(input);
            Console.WriteLine(result);


        }
        static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);

        
            -->reversing a number ;
             Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            string result = ReverseString(number);
            Console.WriteLine(result);

        }
        static string ReverseString(int number)
        {
            string input=number.ToString();
            char[] chars=input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
             */



            /*--->palindrome*/
            /* Console.WriteLine("enter a string");
             string input = Console.ReadLine();
             string reverse = "";
             for(int i=input.Length-1; i>=0;i--)

             {
                 reverse += input[i];
             }
             if (input == reverse )
                 Console.WriteLine("palindrome");
             else
                 Console.WriteLine("not Palindorme");
            -->number palindrome;

                        int number = 1221; 
            string input = number.ToString();
            string reverse = "";
            for(int i=input.Length-1;i>=0;i--)
            {
                reverse += input[i];

            }
            if (input == reverse)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("not Palindrome");
             
             */
            /*
             * Reversing a words;
            Console.WriteLine("enter a word");
            string input = Console.ReadLine();
            string[] word = input.Split(' ');
            Array.Reverse(word);
            string result = string.Join(" ", word);
            Console.WriteLine(result);


            string input = "don't you have manner's";
            string[] words = input.Split(' ');
            Array.Reverse(words);
            string result = string.Join(" ", words);
            Console.WriteLine(result);*/

            /*---> removing duplicates in string:-*/
            /*string input = "csharpcorner";
            string result = RemoveDuplicates(input);
            Console.WriteLine(result);
        }
        static string RemoveDuplicates (string input)
        {
            HashSet<char> seen = new HashSet<char>(); 
            string results = "";
            foreach (char net in input)
            {
                if (seen.Add(net))
                {
                    results+= net;
                }

            }
            return results;*/
            /*int num = 5;
            bool prime=true;
            if (num <= 1)
                prime = false;
            for (int i=2;i*i<=num;i++)
            {
                if (num%i==0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine(prime ? "prime":"not prime");*/
            int num = 17;
            bool prime = true;
            if(num<=1)
                prime = false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine(prime ? "is prime" : "is not prime");
        

    }
    }
}