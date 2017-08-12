using System;
using System.Collections.Generic;

namespace ConsoleApp3BasicExercises
{
    static class Program
    {
        private const int MaxMultiplicationTableNumber = 10;
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


            Console.ReadLine();
        }

        private static void CalculatePerimeterAndArea(int radius)
        {
            var perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Perimeter of circle: {perimeter}");
        }

        private static void DoBasicCalculation(int inputNumber1, string operation, int inputNumber2)
        {
            switch (operation)
            {
                case "+":
                    AddTwoNumbers(inputNumber1, inputNumber2);
                    break;
                case "-":
                    SubstractTwoNumbers(inputNumber1, inputNumber2);
                    break;
                case "/":
                    DivideToIntegers(inputNumber1, inputNumber2);
                    break;
                case "*":
                    MultiplyTwoNumbers(inputNumber1, inputNumber2);
                    break;
                default:
                    Console.WriteLine($"Operation {operation} is not valid");
                    break;
            }
        }

        private static void ValidateLogin()
        {
            var userName = "Adamino";
            var password = "123";

            var loginAttempts = 0;
            const int maxLoginAttempts = 3;

            bool loginAccepted = false; ;
            do
            {
                Console.WriteLine("Please write username");
                var inputUserName = Console.ReadLine();
                Console.WriteLine("Please write password");
                var inputPassword = Console.ReadLine();

                if (userName.Equals(inputUserName) && password.Equals(inputPassword))
                {
                    loginAccepted = true;
                    Console.WriteLine($"You're logged in!");
                }
                else
                {
                    loginAttempts++;
                    Console.WriteLine($"Access denied!");
                }
                if (loginAttempts >= maxLoginAttempts)
                {
                    Console.WriteLine($"Wow you suck!");
                    break;
                }
            } while (!loginAccepted);

        }

        private static void DisplayTriangleOfNumberWithWidth(int numberToDisplay, int width)
        {

            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(numberToDisplay);
                }
                width--;
                Console.WriteLine();
            }
        }

        private static void ReverThreeLetters(string inputChar1, string inputChar2, string inputChar3)
        {
            Console.WriteLine($"{inputChar3} {inputChar2} {inputChar1}");
        }

        private static void AbsoluteValueOfDifference(int inputNumber1, int inputNumber2)
        {
            int result;

            if (inputNumber1 > inputNumber2)
            {
                result = (inputNumber1 - inputNumber2) * 2;
                Console.WriteLine($"{inputNumber1} is greater than {inputNumber2}, therefore we double!");
            }
            else
            {
                result = inputNumber2 - inputNumber1;
            }

            Console.WriteLine($"Absolute value of difference between {inputNumber1} and {inputNumber2} is {result}");
        }

        private static void SumAndTripleIfEqual(int inputNumber1, int inputNumber2)
        {
            var sum = inputNumber1 + inputNumber2;

            if (inputNumber1 == inputNumber2)
            {
                // Triple sum if equal numbers
                sum *= 3;
                Console.WriteLine($"{inputNumber1} and {inputNumber2} are equal, therefore we triple the result!");
            }

            Console.WriteLine(sum);
        }

        private static void ValidatePositiveAndNegativeNumbers(int inputNumber1, int inputNumber2)
        {
            var result =
                inputNumber1 >= 0 && inputNumber2 < 0 ||
                inputNumber2 >= 0 && inputNumber1 < 0;

            Console.WriteLine(result);
        }

        private static void AddFirstCharacterToBeginningAndEnd(string inputString)
        {
            var firstChar = GetFirstCharacterOfString(inputString);
            var output = $"{firstChar}{inputString}{firstChar}";
            Console.WriteLine(output);
        }

        private static void SwapFirstAndLastChar(string inputString)
        {
            var firstChar = GetFirstCharacterOfString(inputString);
            var middleChars = inputString.Substring(1, inputString.Length - 2);
            var lastChar = inputString.Substring(inputString.Length - 1);
            var swuppedString = lastChar + middleChars + firstChar;

            Console.WriteLine(swuppedString);
        }

        private static string GetFirstCharacterOfString(string inputString)
        {
            return inputString.Substring(0, 1);
        }

        private static string GetInputString()
        {
            bool stringAccepted = false;

            string inputString = "";
            do
            {
                Console.Write("Please write a sentence: ");
                inputString = Console.ReadLine();
                if (inputString.Length > 1)
                {
                    stringAccepted = true;
                    return inputString;
                }
            } while (!stringAccepted);
            return inputString;
        }

        private static void RemoveCharacterIndexFromString(string inputString, int indexToRemove)
        {
            bool indexAccepted = false;
            do
            {
                if (indexToRemove <= inputString.Length)
                {
                    var manipulatedString = inputString.Remove(indexToRemove, 1);
                    indexAccepted = true;
                    Console.WriteLine(manipulatedString);
                }
                else
                {
                    throw new IndexOutOfRangeException($"{indexToRemove} is too high");
                }
            } while (!indexAccepted);
        }

        private static void ConvertFromCelsius(int inputNumber1)
        {
            const int kelvinKonvertNumber = 273;

            var kelvinResult = inputNumber1 + kelvinKonvertNumber;
            var fahrenheitResult = inputNumber1 * 18 / 10 + 32;

            Console.WriteLine(
                $"{inputNumber1} degrees celsius is Kelvin = {kelvinResult} and Fahrenheit = {fahrenheitResult}");
        }

        private static void DisplayRectangle(int inputNumber1)
        {
            var rows = 5;
            var columns = 3;

            Console.WriteLine("Now look at this awesome rectangle!");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // If the row is an even number
                    if (i % 2 == 0)
                    {
                        // Write the numbers after eachother
                        Console.Write(inputNumber1);
                    }
                    else
                    {
                        // If the row is uneven, but column is even
                        if (j % 2 == 0)
                        {
                            // Write number
                            Console.Write(inputNumber1);
                        }
                        else
                        {
                            // Else create space between numbers
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }

        private static void RepeatNumber(int inputNumber1)
        {
            var numberOfTimesToRepeat = 4;
            var numberOfTimesToWrite = 4;
            for (var i = 0; i < numberOfTimesToRepeat; i++)
            {
                for (var j = 0; j < numberOfTimesToWrite; j++)
                {
                    Console.Write(inputNumber1 + " ");
                }

                Console.WriteLine();

                for (var j = 0; j < numberOfTimesToWrite; j++)
                {
                    Console.Write(inputNumber1);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// React on age and give compliment accordingly
        /// </summary>
        /// <param name="age"></param>
        private static void ComplimentAge(int age)
        {
            Console.WriteLine(age <= 25 ? $"You look older than {age}" : $"You look younger than {age}");
        }

        /// <summary>
        /// Takes three numbers(x,y,z) as input and print the output of 
        /// (x+y)*z and x*y + y*z
        /// </summary>
        /// <param name="inputNumber1"></param>
        /// <param name="inputNumber2"></param>
        /// <param name="inputNumber3"></param>
        private static void AdditionAndMultiplication(int inputNumber1, int inputNumber2, int inputNumber3)
        {
            var result1 = (inputNumber1 + inputNumber2) * inputNumber3;
            Console.WriteLine($"({inputNumber1} + {inputNumber2}) * {inputNumber3} = {result1}");

            var result2 = inputNumber1 * inputNumber2 + inputNumber2 * inputNumber3;
            Console.WriteLine($"{inputNumber1} * {inputNumber2} + {inputNumber2} * {inputNumber3} = {result2}");
        }

        private static void GetAverage(List<int> numbers)
        {
            var result = 0;

            foreach (var number in numbers)
            {
                result += number;
            }
            result = result / numbers.Count;

            Console.WriteLine($"The average is {result}");
        }

        private static void MultiplicationTable(int inputNumber1)
        {
            for (var i = 0; i <= MaxMultiplicationTableNumber; i++)
            {
                var result = inputNumber1 * i;
                Console.WriteLine($"{inputNumber1} * {i} = {result}");
            }
        }

        private static void AddSubstractMultiplyDivideTwoNumber(int number1, int number2)
        {
            AddTwoNumbers(number1, number2);
            SubstractTwoNumbers(number1, number2);
            MultiplyTwoNumbers(number1, number2);
            DivideToIntegers(number1, number2);

            Console.WriteLine();
        }

        private static void MultiplyTwoNumbers(int number1, int number2)
        {
            var result = number1 * number2;

            Console.WriteLine($"{number1} * {number2} = {result}");
        }

        private static void SubstractTwoNumbers(int number1, int number2)
        {
            var result = number1 - number2;

            Console.WriteLine($"{number1} - {number2} = {result}");
        }

        private static void MultiplyThreeNumbers(int number1, int number2, int number3)
        {
            var result = number1 * number2 * number3;

            Console.WriteLine($"{number1} * {number2} * {number3} = {result}");
        }

        private static void SwapTwoNumbers()
        {
            var input1 = GetInteger();
            Console.WriteLine($"First input {input1}");
            var input2 = GetInteger();
            Console.WriteLine($"Second input {input2}");
            var temp = input1;

            input1 = input2;
            input2 = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine($"First number {input1}");
            Console.WriteLine($"Second number {input2}");
        }

        private static void DisplayResultOfStaticTestData()
        {
            var resultOfString = "The result of";
            Console.WriteLine($"{resultOfString} -1 + 4 * 6 is = {-1 + 4 * 6}");
            Console.WriteLine($"{resultOfString} ( 35+ 5 ) % 7 = {(35 + 5) % 7}");
            Console.WriteLine($"{resultOfString} 14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            Console.WriteLine($"{resultOfString} 2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
        }

        private static void DivideToIntegers(int inputNumber1, int inputNumber2)
        {
            var result = 0;

            try
            {
                result = inputNumber1 / inputNumber2;
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("Are you seriously trying to divide by zero!?");
                Console.WriteLine(divideByZeroException);
            }

            Console.WriteLine($"{inputNumber1} / {inputNumber2} = {result}");
        }

        private static void AddTwoNumbers(int inputNumber1, int inputNumber2)
        {
            var result = inputNumber1 + inputNumber2;

            Console.WriteLine($"{inputNumber1} + {inputNumber2} = {result}");
        }


        private static int GetInteger()
        {
            bool numbersAccepted = false;
            var inputNumber = 0;

            do
            {
                try
                {
                    Console.WriteLine("Please write number");

                    inputNumber = Convert.ToInt32(Console.ReadLine());
                    numbersAccepted = true;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("Did you write a number?");
                    Console.WriteLine(formatException);
                }
            } while (!numbersAccepted);
            return inputNumber;
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