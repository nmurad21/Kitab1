using System;
using Kitab1.Models;
namespace Kitab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = GetInputInt("Say daxil edin:", 0);
            Book[] kitab = new Book[length];
            for (int i = 0; i < length; i++)
            {
                string Genre = GetInputStr($"Janri daxil edin:", 1);
                int No = GetInputInt($"Nomresini daxil edin:", 1);
                string Name = GetInputStr($"Adini daxil edin:", 1);
                int Price = GetInputInt($"Qiymetini daxil edin:", 1);
                int Count = GetInputInt($"Sayini daxil edin:", 1,30);

            }
           
        }
        static int GetInputInt(string Name, int min, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.WriteLine(Name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);

            return input;
        }
        static string GetInputStr(string Name, int min, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine(Name);
                input = Console.ReadLine();
            } while (input.Length < min || input.Length > max);

            return input;
        }
    }
}
