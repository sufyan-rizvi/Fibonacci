using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Fibonacci();
        }

        static void Fibonacci()
        {
            int myNumber;
            int firstNum = 0, secondNum = 1, thirdNum;




            Console.WriteLine("Enter the length of fibonacci number: ");
            myNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The series is: ");
            for (int i = 0; i < myNumber + 1; i++)
            {
                Console.WriteLine(firstNum);
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;

            }
            Console.ReadLine();
        }
    }
}
