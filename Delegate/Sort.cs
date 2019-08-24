using Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Sort
    {
        public int[] table;

        public void BubbleSort(int[] table, LogDelegate logs)
        {
            SortStarting?.Invoke(this, new SortEventArgs() { Message = "Startujemy z sortowaniem" });
            logs.Invoke("start");
            int n = table.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (table[i] > table[i + 1])
                    {
                        int tmp = table[i];
                        table[i] = table[i + 1];
                        table[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
            logs.Invoke("koniec");
        }

        public void InsertSort(int[] table, LogDelegate logs)
        {
            logs.Invoke("start");
            int k, j;
            int n = table.Length;
            for (int i = 1; i < n; i++)
            {
                k = table[i];
                j = i - 1;
                while (j >= 0 && table[j] > k)
                {
                    table[j + 1] = table[j];
                    --j;
                }
                table[j + 1] = k;
                var x = logs;
            }
            logs.Invoke("koniec");
        }
        public event EventHandler<SortEventArgs> SortStarting;
        

        
    }
    public delegate void LogDelegate(string text);
}
