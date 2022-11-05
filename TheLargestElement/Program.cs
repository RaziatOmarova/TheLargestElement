using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Наибольший элемент:" + Find(Generation(arr)));
            Console.ReadKey();
        }
        static int[] Generation(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine();
            return arr;
        }
        static int Find(int[] arr)
        {
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (temp < arr[i])
                {
                    temp = arr[i];
                    arr[i] = i;
                }
            }
            return temp;
        }
    }
}
