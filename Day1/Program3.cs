using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program3
    {
        static void Main()
        {
            Console.Write("Please enter your name: ");
            string userName;
            userName = Console.ReadLine();
            string age;
            Console.Write("Enter your age:");
            age = Console.ReadLine();
            Console.WriteLine("Hi" + userName + "!");
            Console.WriteLine("Hi, {1}! Your age is {0}"
                , age, userName);
        }
    }
}
