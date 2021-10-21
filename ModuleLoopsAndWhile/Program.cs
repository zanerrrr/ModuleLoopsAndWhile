using System;

namespace ModuleLoopsAndWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are the numbers: 1, 2, 3, 4, 5, 11, 12, 13, 14, 15, 21, 22, 23, 24, 25.");
                int[] simpleArray = { 1, 2, 3, 4, 5, 11, 12, 13, 14, 15, 21, 22, 23, 24, 25 };
                int sum = 0;
                for (int i = 0; i < simpleArray.Length; i++)
                {
                sum += simpleArray[i];
                }
                Console.WriteLine($"The sum of the numbers: {sum}\n");
            
            //string[] animals = { "cat", "dog", "cow" };
            //Console.WriteLine(animals.Length);
            //Console.WriteLine(animals[2]);
            //for (int i = 0; i < animals.Length; i++)
            //{
            //    Console.WriteLine(animals[i]);
            //}

            //foreach (string i in animals)
            //{
            //    Console.WriteLine(i);
            //}

            //Array.Sort(animals);
            //foreach (string i in animals)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
    }
}
