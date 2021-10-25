using System;
using System.Linq;

namespace ModuleLoopsAndWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("These are the numbers: 1, 2, 3, 4, 5, 11, 12, 13, 14, 15, 21, 22, 23, 24, 25.");
            //int[] simpleArray = { 1, 2, 3, 4, 5, 11, 12, 13, 14, 15, 21, 22, 23, 24, 25 };
            //int sum = 0;
            //    for (int i = 0; i < simpleArray.Length; i++)
            //    {
            //        sum += simpleArray[i];
            //    }

            //Console.WriteLine(simpleArray.Max());
            //Console.WriteLine($"The sum of the numbers: {sum}\n");

            //simpleArray.Reverse();

            int[] numbers = { 1, 2, 4, 5, 5, 44, 86, 122, 9, 7 };
            Array.Sort(numbers);
            foreach (int result in numbers)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine( result + " is even number");
                }
                else
                {
                    Console.WriteLine(result + " is odd numer");
                }
            }






            Console.ReadLine();
            //string[] animals = { "cat", "dog", "cow" };
            //Console.WriteLine(animals.Length);
            //Console.WriteLine(animals[2]);
            //for (int i = 0; i < animals.Length; i++)
            //{
            //    Console.WriteLine(animals[i]);
            //}
            //foreach (strVal in Animals)
            //    if (strVal.EndsWith("a"));
            //    {
            //    Console.WriteLine(strVal);
            //    }

            //strVal.Equals
            //strVal.Contains 
            ////foreach (string i in animals)
            //{
            //    Console.WriteLine(i);
            //}

            //Array.Sort(animals);
            //foreach (string i in animals)
            //{
            //    Console.WriteLine(i);
            //}

        }
//        static void OutOfRange()
//        {
//            int[] arr = { 1, 2, 3 };
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine($"Array item value: {arr[i]}");
//            }
//        }

//        static void IterateLoop()
//        {
//            int[,] array = { { 11, 23, 44 }, { 34, 422, 332 } };
//            string[,] strArray = { { "name", "surname" }, { "age", "wight" } };
//​
//            for (int i = 0; i < 2; i++)
//            {
//                for (int j = 0; j < 2; j++)
//                {
//                    Console.WriteLine(strArray[i, j]);
//                }
//            }
//        }
//        static void FindMaxNumber()
//        {
//            int[] intArray = { 123123213, 231223, 2222, 34334 };
//            var biggestVal = intArray.Max();
//            var smallestVal = intArray.Min();
//        }

            
    }
}
