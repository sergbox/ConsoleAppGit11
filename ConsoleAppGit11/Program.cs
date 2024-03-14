using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sin(x) - (2* Math.Cos(x));
        }
    }
}
