using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 5, 6, 7, 8 };
            int[] arr2 = { 14, 9, 40, -9 };

            //Console.WriteLine(arr1.Length);
            //Array.Resize(ref arr1, arr1.Length + 1);
            //arr1[6] = 15;

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in arr2)
            //{
            //    Array.Resize(ref arr1, arr1.Length + 1);
            //    arr1[arr1.Length - 1] = item;
            //}
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}


            int[] arr = {3,4,16,3,5,8,97,7 };
            int[] single = { };
            int[] plural = new int[0];

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    Array.Resize(ref plural,plural.Length+1);
                    plural[plural.Length - 1] = item;
                }
                else
                {
                    Array.Resize(ref single, single.Length + 1);
                    single[single.Length - 1] = item;
                }
            }

            foreach (var item in single)
            {
                Console.WriteLine(item);
            }
            foreach (var item in plural)
            {
                Console.WriteLine(item);
            }



        }
    }
}
