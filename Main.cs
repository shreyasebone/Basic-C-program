using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    internal class MainClass {
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static void Main(string[] args) {
            Console.WriteLine("List of given case");
            Console.WriteLine("1. prime number");
            Console.WriteLine("2. String Anagram");
            Console.WriteLine("3. Sum of N numbers");
            Console.WriteLine("4. Factorial of given number");
            Console.WriteLine("5. Reverse String");
            Console.WriteLine("6 Two sum problem");
            Console.WriteLine("enter the case");
            int inputCase = Convert.ToInt32(Console.ReadLine());
            switch (inputCase) {
                case 1:
                    PrimeNumber primeNumber = new PrimeNumber();
                    Console.WriteLine("enter the number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    bool isPrimeNumber = primeNumber.isPrimeNumber(number);
                    if (isPrimeNumber) {
                        Console.WriteLine(number + " Given number is prime number ");
                    }
                    else {
                        Console.WriteLine(number + " Given number is not prime number");
                    }
                    break;

                case 2:
                    StringAnagram stringAnagram = new StringAnagram();
                    Console.WriteLine("enter first String");
                    string firstString = Console.ReadLine();
                    Console.WriteLine("enter Second String");
                    string secondString = Console.ReadLine();
                    bool result = stringAnagram.isAnagram(firstString, secondString);
                    Console.WriteLine(result);
                    break;

                case 3:
                    SumOfNumber sumOfNumber = new SumOfNumber();
                    Console.WriteLine("enter the number");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    int resultOfNumber = sumOfNumber.returnSumOfNumber(inputNumber);
                    Console.WriteLine(resultOfNumber);
                    break;

                case 4:
                    FactorialOfNumber factorialOfNumber = new FactorialOfNumber();
                    int inputFactNumber = Convert.ToInt32(Console.ReadLine());
                    int factorial = factorialOfNumber.returnFactorialOfNumber(inputFactNumber);
                    Console.WriteLine(factorial);
                    break;

                case 5:
                    StringReverse stringReverse = new StringReverse();
                    Console.WriteLine("enter the inputString");
                    string inputString = Console.ReadLine();
                    string reverseString = stringReverse.returnReverseString(inputString);
                    Console.WriteLine(reverseString);
                    break;

                case 6:
                    TwoSumProblem twoSumProblem = new TwoSumProblem();
                    int[] inputArray = { 2, 3, 7, 11, 9 };
                    int targetInput = 6;
                    bool output = twoSumProblem.twoSum(inputArray, targetInput);
                    Console.WriteLine(output);
                    break;

                default:
                    Console.WriteLine("wrong choice");
                    break;


            }
        }
    }
}
