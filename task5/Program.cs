using System;
using System.IO;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            String input =  File.ReadAllText(@"array.txt");
            int i = 0, j = 0;
            int[,] array = new int[5,5];
            int count_good = 0, count_bad = 0;
            bool good = false,bad = false;
            foreach(var row in input.Split('\n'))
            {
                j=0;
                foreach(var col in row.Trim().Split(' '))
                {
                    array[i,j] = int.Parse(col.Trim());
                    if(array[i,j] >= 190 && good == false)
                        {
                            count_good++;
                            good = true;
                        }
                    if(array[i,j] <= 150 && bad == false)
                        {
                            count_bad++;
                            bad = true;
                        }
                    Console.Write("{0,-5}",array[i,j]);
                    j++;
                }
                good = false;
                bad = false;
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("Students with excellent mark: "+count_good+
            " Students that did not pass: "+ count_bad);
            
        }
    }
}
