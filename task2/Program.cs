using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte size = 24;
            int[] array = new int[size];
            Random r = new Random();
            for (byte i = 0; i<size;i++)
            {
                array[i] = r.Next(-8,15);
                Console.Write(array[i]+" ");
            }
            int first = 0;
            byte first_pos = 0;
            byte last_pos = 23;
            for (byte i = 0; i<last_pos; i++)
            {
                if(array[i] >= 0)
                {
                    first = array[i];
                    first_pos = i;
                    for(byte j = last_pos; j>first_pos;j--)
                        if(array[j] >= 0)
                            {
                                array[i]  = array[j];
                                array[j] = first;
                                last_pos = (byte)(j-1);
                                break;
                            }
                }
            }
            Console.WriteLine();
            for(byte i = 0; i<size; i++)
                Console.Write(array[i]+" ");

        }
    }
}
