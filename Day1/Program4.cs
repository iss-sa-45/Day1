using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program4
    {
        static void Main()
        {

            //int i = 10;
            //int result = i * 4;
            //Console.WriteLine("{0} * 4 = {1}", i, result);

            //int i = 10;
            //Console.WriteLine("{0} * {1} = {1}", i, i * 4);

            Console.Write("Enter your salary: ");
            string input = Console.ReadLine();
            double salary = Convert.ToDouble(input);

            double tax = 0.05 * salary;
            Console.WriteLine("Your salary is ${0:0,000.00}, your tax is ${1:0,0.00}"
                , salary, tax);
            Console.WriteLine("Your salary is ${0:0,000.##}, your tax is ${1:0,0.##}"
                , salary, tax);
            Console.WriteLine("Your salary is ${0:#,###.00}, your tax is ${1:#,###.00}"
                , salary, tax);
            Console.WriteLine("Your salary is ${0:c}, your tax is ${1:c}"
                , salary, tax);
            Console.WriteLine("{{0}} {0}, your tax is ${1:c}"
                , salary, tax);

        }
    }
}
