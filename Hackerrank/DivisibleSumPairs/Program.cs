using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');

        int[] a = a_temp.Select(t => Int32.Parse(t)).ToArray();

        int totalPair = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((a[i] + a[j]) % k == 0)
                    totalPair++;
            }
        }

        Console.WriteLine(totalPair);
    } 
}