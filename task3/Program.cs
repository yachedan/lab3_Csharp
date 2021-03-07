using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 0;
            Console.WriteLine("Input a number: ");
            x = Convert.ToByte(Console.ReadLine());
            Random r = new Random();
            byte size = (byte)r.Next(3,20);
            byte[,] array = new byte[size,size];
            bool[] X = new bool[size];
            byte max = 0;
            for(byte i = 0; i<size; i++)
            {
                for(byte j = 0; j<size; j++)
                {
                    array[i,j] = (byte)r.Next(0,100);
                    Console.Write("{0,-5}",array[i,j]);
                    if(array[i,j] > max)
                        max = array[i,j];
                }
                Console.WriteLine();
                if(max<=x)
                    X[i] = true;
                else
                    X[i] = false;
            }
            for(byte i = 0; i<size; i++)
                Console.Write(X[i]+" ");
                    

        }
    }
}