using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Mukushev Azat");
            Console.WriteLine("Введите 2 числа:");
            int numOne = Int32.Parse(Console.ReadLine());
            int numTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine(numOne + numTwo);

        }
    }

}
