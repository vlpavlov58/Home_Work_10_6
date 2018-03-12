using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_10_6
{
    class Program
    {
        static int MaxElement(int x)
        {
            int[] array = { 1, 5, 69, 78, 2, 37, 0, 7, 3 };
            int max = array[0];
            
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                
            }
            return max;
            
        }

        static int MinElement (int x)
        {
            int[] array = { 1, 5, 69, 78, 2, 37, 0, 7, 3 };
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
            
            
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 5, 69, 78, 2, 37, 0, 7, 3 };
            int max = array[0];
            int min = array[0];
            Console.WriteLine($"Max Element: = {MaxElement(max)}");
            Console.WriteLine($"Min Element: = {MinElement(min)}");
        }
    }
}
