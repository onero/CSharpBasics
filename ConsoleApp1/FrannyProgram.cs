using System;

namespace ConsoleApp1HelloWorld
{
    internal static class FrannyProgram
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //if (name == "Adam")
            //{
            //    Console.WriteLine("Franny loves you <3");
            //}
            //else
            
            //{
            //    Console.WriteLine("Hello " + name);   
            //}

            Console.WriteLine("Write a number");
            var numberAsString = Console.ReadLine();
            var number = int.Parse(numberAsString);

            Console.WriteLine("Write another number");
            var numberAsString2 = Console.ReadLine();
            var number2 = int.Parse(numberAsString2);

            var result = number + number2;
            Console.WriteLine(number + " + " + number2 + " = " + result);

        }
    }
}