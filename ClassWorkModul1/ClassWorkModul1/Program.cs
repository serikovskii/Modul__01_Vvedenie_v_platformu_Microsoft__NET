using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkModul1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mukushev Azat");
            Console.WriteLine("Введите 2 числа:");
            int numOne = Int32.Parse(Console.ReadLine());
            int numTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine(numOne + numTwo);
        }
    }
}
