using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите одны из цифр, для получеия рекомендаций:");
        Console.WriteLine("1.");
        Console.WriteLine("2.");
        Console.WriteLine("3.");
        Console.WriteLine("4.");
        string wrtstr = Console.ReadLine();
        int wrtchar = Int32.Parse(wrtstr);
            if (wrtchar == 1)
            {
            Console.WriteLine("В данном разделе, рекомендуем:");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            }
            else if (wrtchar == 2)
            {
            Console.WriteLine("В данном разделе, рекомендуем:");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            }
            else if (wrtchar == 3)
            {
            Console.WriteLine("В данном разделе, рекомендуем:");
            Console.WriteLine("11");
            Console.WriteLine("12");
            Console.WriteLine("13");
            }
            else if (wrtchar == 4)
            {
            Console.WriteLine("В данном разделе, рекомендуем:");
            Console.WriteLine("14");
            Console.WriteLine("15");
            Console.WriteLine("16");
            }
            else
            {
            Console.WriteLine("Что-то вы не то ввели!");
            }
        Console.ReadLine();
        }
    }
}
