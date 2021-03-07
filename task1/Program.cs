using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            Console.WriteLine("Insert size of an array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Insert array values:");
            for (int i = 0; i<n; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<n; i++)
                Console.Write(array[i]+" ");
            int count = 0;
            for(int i = 0; i<n; i++)
                if((array[i]%2)!=0)
                    count++;
            Console.WriteLine("\nCount of odd numbers in array: "+count);
        }
    }
}
