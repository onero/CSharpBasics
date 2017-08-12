using System;
using System.Collections.Generic;
using static ConsoleApp3BasicExercises.BLL.BasicExerciseManager;

namespace ConsoleApp3BasicExercises
{
    static class Program
    {
        private const string Name = "Adam";

        private const string WelcomeMessage = "Welcome to this awesome";

        static void Main(string[] args)
        {
            int inputNumber1;
            int inputNumber2;

            /********BASICS********/

            // Assignment 1
            PrintWelcomeToSpecificMethod("Name greeting method");
            PrintName();


            // Assignment 2
            PrintWelcomeToSpecificMethod("Addition method");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            AddTwoNumbers(inputNumber1, inputNumber2);

            // Assignment 3
            PrintWelcomeToSpecificMethod("Division method (of whole numbers to wholenumbers)");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            DivideToIntegers(inputNumber1, inputNumber2);

            // Assignment 4
            PrintWelcomeToSpecificMethod("Test data arythmetic method");
            DisplayResultOfStaticTestData();

            // Assignment 5
            PrintWelcomeToSpecificMethod("Number swapping method");
            SwapTwoNumbers();

            // Assignment 6
            PrintWelcomeToSpecificMethod("Thrice Multiplication method");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            var inputNumber3 = GetInteger();
            MultiplyThreeNumbers(inputNumber1, inputNumber2, inputNumber3);

            // Assignment 7
            PrintWelcomeToSpecificMethod("Add/Subtract/Multiply/Divide method");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            AddSubstractMultiplyDivideTwoNumber(inputNumber1, inputNumber2);

            // Assignment 8
            PrintWelcomeToSpecificMethod("Multiplication table method");
            inputNumber1 = GetInteger();
            MultiplicationTable(inputNumber1);

            // Assignment 9
            PrintWelcomeToSpecificMethod("Get average method");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            inputNumber3 = GetInteger();
            var inputNumber4 = GetInteger();

            var numbers = new List<int> { inputNumber1, inputNumber2, inputNumber3, inputNumber4 };
            GetAverage(numbers);

            // Assignment 10
            PrintWelcomeToSpecificMethod("Thrice addition method");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            inputNumber3 = GetInteger();

            AdditionAndMultiplication(inputNumber1, inputNumber2, inputNumber3);

            // Assignment 11
            PrintWelcomeToSpecificMethod("Age compliment method");
            var age = GetInteger();
            ComplimentAge(age);

            // Assignment 12
            PrintWelcomeToSpecificMethod("Repeat number method");
            inputNumber1 = GetInteger();
            RepeatNumber(inputNumber1);

            // Assignment 13
            PrintWelcomeToSpecificMethod("Rectangle of 3 columns method");
            inputNumber1 = GetInteger();
            DisplayRectangle(inputNumber1);

            // Assignment 14
            PrintWelcomeToSpecificMethod("Convert from celsius to Kelvin & Fahrenheit method");
            inputNumber1 = GetInteger();
            ConvertFromCelsius(inputNumber1);

            // Assignment 15
            PrintWelcomeToSpecificMethod("Remove specified character method");
            var inputString = GetInputString();
            Console.Write("Please write a character to remove from sentence: ");
            var indexToRemove = GetInteger();

            RemoveCharacterIndexFromString(inputString, indexToRemove);


            // Assignment 16
            PrintWelcomeToSpecificMethod("Swap first and last character of string method");
            inputString = GetInputString();
            SwapFirstAndLastChar(inputString);

            // Assignment 17
            PrintWelcomeToSpecificMethod("Add first character to beginning and end method");
            inputString = GetInputString();
            AddFirstCharacterToBeginningAndEnd(inputString);

            // Assignment 18
            PrintWelcomeToSpecificMethod("Validate positive and negative integers method");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            ValidatePositiveAndNegativeNumbers(inputNumber1, inputNumber2);

            // Assignment 19
            PrintWelcomeToSpecificMethod("Compute sum, but triple if equal numbers method");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            SumAndTripleIfEqual(inputNumber1, inputNumber2);

            // Assignment 20
            PrintWelcomeToSpecificMethod("Absolute value of difference, double that value if first is greater method");
            inputNumber1 = GetInteger();
            inputNumber2 = GetInteger();
            AbsoluteValueOfDifference(inputNumber1, inputNumber2);

            /********DATA TYPES********/
            // Assignment 1
            PrintWelcomeToSpecificMethod("Reverse letters method");
            Console.WriteLine("Write first char");
            var inputChar1 = Console.ReadLine();
            Console.WriteLine("Write second char");
            var inputChar2 = Console.ReadLine();
            Console.WriteLine("Write third char");
            var inputChar3 = Console.ReadLine();
            ReverThreeLetters(inputChar1, inputChar2, inputChar3);

            // Assignment 2
            PrintWelcomeToSpecificMethod("Number triangle with width method");
            inputNumber1 = GetInteger();
            Console.Write("Write a width of triangle");
            inputNumber2 = GetInteger();
            DisplayTriangleOfNumberWithWidth(inputNumber1, inputNumber2);

            // Assignment 3
            PrintWelcomeToSpecificMethod("Login validation method");
            ValidateLogin();

            // Assignment 4
            PrintWelcomeToSpecificMethod("Basic calculator method");
            inputNumber1 = GetInteger();
            Console.WriteLine("Please write an operator (+, -,*, /)");
            var operation = Console.ReadLine();
            inputNumber2 = GetInteger();

            DoBasicCalculation(inputNumber1, operation, inputNumber2);

            // Assignment 5
            PrintWelcomeToSpecificMethod("Calculate oerimeter and area of circle method");
            Console.Write("Please provide a radius: ");
            var radius = GetInteger();
            CalculatePerimeterAndArea(radius);


            Console.WriteLine("Click enter to exit...");
            Console.ReadLine();
        }



        private static void PrintWelcomeToSpecificMethod(string methodToWelcomeAt)
        {
            Console.WriteLine($"{WelcomeMessage} {methodToWelcomeAt}");
        }

        private static void PrintName()
        {
            Console.WriteLine("Hello");
            Console.WriteLine($"{Name}");
        }
    }
}