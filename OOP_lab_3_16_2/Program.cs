using System;
using System.IO;

namespace OOP_lab_3_16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("D:/111.txt");

            string str = fromFile.ReadToEnd();

            string[] numbers = str.Split(new char[] {' ','\r','\n' }, StringSplitOptions.RemoveEmptyEntries);

            int[] a = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; ++i)
            {
                a[i] = int.Parse(numbers[i]);
            }

            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                sum += a[i];
            }

            Console.WriteLine("\nСума елементiв масиву: {0}", sum);
        }
    }
}
