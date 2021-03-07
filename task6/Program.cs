using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int y_size = 0;
            Console.WriteLine("Input size: ");
            y_size = Convert.ToInt32(Console.ReadLine());
            int[][] array = new int[y_size][];
            Random r = new Random();
            int[] odd_numbers = new int[y_size];
            for (int i = 0; i<y_size; i++)
            {
                int x_size = r.Next(1,y_size);
                array[i] = new int [x_size];
                for(int j = 0; j<x_size; j++)
                    {
                        array[i][j] = r.Next(0,100);
                        if((array[i][j] % 2) != 0)
                            odd_numbers[i] = array[i][j];
                        Console.Write("{0,-5}",array[i][j]);
                    }
                Console.WriteLine();
            }
            Console.Write("Last odd numbers: ");
            for(int i = 0; i<y_size; i++)
                Console.Write(odd_numbers[i] + " "); 
            
        }
    }
}
