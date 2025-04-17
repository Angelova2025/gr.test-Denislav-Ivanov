using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Threading;
using System.Xml.Linq;

namespace _9_klas
{

    class Family
    {
        public Person[] People;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //3 9 5 1 9 7 4 9
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
                Console.WriteLine($"Най голям елемент: {max}");

            
             int sum = 0;
            for (int i = 0;i < array.Length; i++)
            {
                sum = sum + array[i];
                
            }
            Console.WriteLine($"Сума на елемнтите: {sum}");

        }
       


    }
}