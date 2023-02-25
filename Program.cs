using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberStrokes;

            Console.WriteLine("Введите количество ударов по боссу");
            numberStrokes = Convert.ToInt32(Console.ReadLine());
            while  (numberStrokes --> 0 ) 
            {
                Console.WriteLine(" Вы нанесли ударов ");
            }
        }
    }
}
