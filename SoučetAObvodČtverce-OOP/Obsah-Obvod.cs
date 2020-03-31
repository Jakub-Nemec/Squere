using System;
namespace SoučetAObvodČtverce_OOP
{
    public class Obsah_Obvod
    {

    public void sum()
        {
            Console.Write("Your number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Your second number:");
            double num2 = double.Parse(Console.ReadLine());

            double obvod = 2 * (num1 + num2);
            double obsah = num1 * num2;

            Console.WriteLine("Circuit is: {0}cm", obvod);
            Console.WriteLine("Content is: {0}cm ", obsah);
        }

    }
}
