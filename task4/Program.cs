using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x_size = 0;
            byte y_size = 0;
            Console.WriteLine("Input size of an array: ");
            y_size = Convert.ToByte(Console.ReadLine());
            x_size = Convert.ToByte(Console.ReadLine());
            Random r = new Random();
            byte[,] array = new byte[y_size,x_size]; 
            byte max = 0;
            byte max_ypos = 0;
            for(byte i = 0; i < y_size; i++)
            {
                for(byte j = 0; j < x_size; j++)
                {
                     array[i,j] = (byte)r.Next(0,100);
                     Console.Write("{0,-5}",array[i,j]);
                }
                Console.WriteLine();
                if(array[i,i]>max)
                {
                    max = array[i,i];
                    max_ypos = i;
                }
            }
            Console.WriteLine("Row: "+max_ypos+" Value: "+max);
            

        }
    }
}
