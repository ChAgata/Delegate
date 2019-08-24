using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. niebieski");
            Console.WriteLine("2. czerwony");
            int color = int.Parse(Console.ReadLine());
            int[] table = { 3, 4, 5, 99, 6, 2, 7, 8 };
            Sort sort = new Sort();
            sort.SortStarting += SortOnSortStarting;
            if(color == 1)
            {
                sort.BubbleSort(table, BlueLogger);
                sort.InsertSort(table, BlueLogger);
            }
            else if(color == 2)
            {
                sort.BubbleSort(table, RedLogger);
                sort.InsertSort(table, RedLogger);
            }
            Console.ReadLine();
        }

        private static void SortOnSortStarting(object sender, SortEventArgs e)
        {
            Console.WriteLine(e.Message); ;
        }

        private static void BlueLogger(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        private static void RedLogger(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
    
}
