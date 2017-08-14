using System;
using System.Collections.Generic;

namespace ConsoleApp3BasicExercises.BLL
{
    public static class BasicExerciseManager
    {
        private const int MaxMultiplicationTableNumber = 10;

        public static void CalculatePerimeterAndArea(int radius)
        {
            var perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Perimeter of circle: {perimeter}");
        }

        public static void DoBasicCalculation(int inputNumber1, string operation, int inputNumber2)
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

        public static void ValidateLogin()
        {
            var userName = "Adamino";
            var password = "123";

            var loginAttempts = 0;
            const int maxLoginAttempts = 3;

            bool loginAccepted = false;
            ;
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

        public static void DisplayTriangleOfNumberWithWidth(int numberToDisplay, int width)
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

        public static void ReverThreeLetters(string inputChar1, string inputChar2, string inputChar3)
        {
            Console.WriteLine($"{inputChar3} {inputChar2} {inputChar1}");
        }

        public static void AbsoluteValueOfDifference(int inputNumber1, int inputNumber2)
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

        public static void SumAndTripleIfEqual(int inputNumber1, int inputNumber2)
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

        public static void ValidatePositiveAndNegativeNumbers(int inputNumber1, int inputNumber2)
        {
            var result =
                inputNumber1 >= 0 && inputNumber2 < 0 ||
                inputNumber2 >= 0 && inputNumber1 < 0;

            Console.WriteLine(result);
        }

        public static void AddFirstCharacterToBeginningAndEnd(string inputString)
        {
            var firstChar = GetFirstCharacterOfString(inputString);
            var output = $"{firstChar}{inputString}{firstChar}";
            Console.WriteLine(output);
        }

        public static void SwapFirstAndLastChar(string inputString)
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

        public static string GetInputString()
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

        public static void RemoveCharacterIndexFromString(string inputString, int indexToRemove)
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

        public static void ConvertFromCelsius(int inputNumber1)
        {
            const int kelvinKonvertNumber = 273;

            var kelvinResult = inputNumber1 + kelvinKonvertNumber;
            var fahrenheitResult = inputNumber1 * 18 / 10 + 32;

            Console.WriteLine(
                $"{inputNumber1} degrees celsius is Kelvin = {kelvinResult} and Fahrenheit = {fahrenheitResult}");
        }

        public static void DisplayRectangle(int inputNumber1)
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

        public static void RepeatNumber(int inputNumber1)
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
        public static void ComplimentAge(int age)
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
        public static void AdditionAndMultiplication(int inputNumber1, int inputNumber2, int inputNumber3)
        {
            var result1 = (inputNumber1 + inputNumber2) * inputNumber3;
            Console.WriteLine($"({inputNumber1} + {inputNumber2}) * {inputNumber3} = {result1}");

            var result2 = inputNumber1 * inputNumber2 + inputNumber2 * inputNumber3;
            Console.WriteLine($"{inputNumber1} * {inputNumber2} + {inputNumber2} * {inputNumber3} = {result2}");
        }

        public static void GetAverage(List<int> numbers)
        {
            var result = 0;

            foreach (var number in numbers)
            {
                result += number;
            }
            result = result / numbers.Count;

            Console.WriteLine($"The average is {result}");
        }

        public static void MultiplicationTable(int inputNumber1)
        {
            for (var i = 0; i <= MaxMultiplicationTableNumber; i++)
            {
                var result = inputNumber1 * i;
                Console.WriteLine($"{inputNumber1} * {i} = {result}");
            }
        }

        public static void AddSubstractMultiplyDivideTwoNumber(int number1, int number2)
        {
            AddTwoNumbers(number1, number2);
            SubstractTwoNumbers(number1, number2);
            MultiplyTwoNumbers(number1, number2);
            DivideToIntegers(number1, number2);

            Console.WriteLine();
        }

        public static void MultiplyTwoNumbers(int number1, int number2)
        {
            var result = number1 * number2;

            Console.WriteLine($"{number1} * {number2} = {result}");
        }

        public static void SubstractTwoNumbers(int number1, int number2)
        {
            var result = number1 - number2;

            Console.WriteLine($"{number1} - {number2} = {result}");
        }

        public static void MultiplyThreeNumbers(int number1, int number2, int number3)
        {
            var result = number1 * number2 * number3;

            Console.WriteLine($"{number1} * {number2} * {number3} = {result}");
        }

        public static void SwapTwoNumbers()
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

        public static void DisplayResultOfStaticTestData()
        {
            var resultOfString = "The result of";
            Console.WriteLine($"{resultOfString} -1 + 4 * 6 is = {-1 + 4 * 6}");
            Console.WriteLine($"{resultOfString} ( 35+ 5 ) % 7 = {(35 + 5) % 7}");
            Console.WriteLine($"{resultOfString} 14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            Console.WriteLine($"{resultOfString} 2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
        }

        public static void DivideToIntegers(int inputNumber1, int inputNumber2)
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

        public static void AddTwoNumbers(int inputNumber1, int inputNumber2)
        {
            var result = inputNumber1 + inputNumber2;

            Console.WriteLine($"{inputNumber1} + {inputNumber2} = {result}");
        }


        public static int GetInteger()
        {
            int inputNumber;

            Console.WriteLine("Please write a number");
            while (ParseInteger(out inputNumber))
            {
                Console.WriteLine("Your input was not a number");
            }
            return inputNumber;
        }

        private static bool ParseInteger(out int inputNumber)
        {
            return !int.TryParse(Console.ReadLine(), out inputNumber);
        }
    }
}