using System;


namespace delloite
{
    class Program
    {
        static void Main(string[] args)
        {
            solution obj = new solution();
            int[] a = { 1, 2, 3, 4, 5 };
            int k = 4;
            int[] result = obj.Solution(a, k);
            //Console.Write(result);
            foreach (int index in result)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();

        }


    }

    class solution
    {
        public int[] Solution(int[] a, int k)
        {
            int iterate = 0;
            while (iterate != k) {
                int[] newArray = new int[a.Length];
                Array.Copy(a, 0, newArray, 1, a.Length - 1);
                newArray[0] = a[a.Length - 1];
                a = newArray;
                iterate++;
            }

            return a;
        }
    }
}

