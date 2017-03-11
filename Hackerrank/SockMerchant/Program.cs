using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');

        int[] c = new int[n];
        for (int i=0;i<n;i++)
        {
            c[i] = Int32.Parse(c_temp[i]);
        }

        Dictionary<int, int> sockDict = new Dictionary<int, int>();
        for (int i=0;i<n;i++)
        {
            var tags = sockDict.FirstOrDefault(t => t.Key == c[i]);
            if (tags.Equals(new KeyValuePair<int,int>()))
            {
                sockDict.Add(c[i], 1);
            }
            else
            {
                sockDict[c[i]]++;
            } 
        }

        int totalSocks = 0;
        foreach(var kvp in sockDict)
        {
            int soldSocks = (int) Math.Floor((double)kvp.Value / 2);
            totalSocks += soldSocks;
        }
        Console.WriteLine(totalSocks);
    }
}