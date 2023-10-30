using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyArr
    {
        int[] arr;
        public int Length;

        public MyArr(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        // Перегружаем индексатор
        public int this[double index]
        {
            get
            {
                return arr[(int)Math.Round(index)];
            }

            set
            {
                arr[(int)Math.Round(index)] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArr arr = new MyArr(101);
            arr[4.51] = 5;
            arr[9.49] = 9;
            arr[99.9] = 100;
            ;

            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
                

            Console.ReadLine();
        }
    }
}