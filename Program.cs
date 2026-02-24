using System;
using Xunit;

namespace MyFirstApp
{
class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число"); 
            string input = Console.ReadLine();
            int number = int.Parse(input); 

            int n1 = number % 10; 
            int n2 = (number / 10) % 10; 
            int n3 = number / 100;

            Console.WriteLine("наибольшее число: "); 
          
            if (n1 < n2 && n3 < n2)
            {
                if (n1 < n3)
                {
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n1);
                }   
            }
            else
            {
               Console.WriteLine(n2); 
            }
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            // Console.WriteLine(n3);
    }
}
}