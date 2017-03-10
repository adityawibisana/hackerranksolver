using System;

class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = new int[n];

        int max = Int32.MinValue;
        for (int i=0;i<n;i++)
        {
            height[i] = Int32.Parse(height_temp[i]);
            if (height[i]>max)
            {
                max = height[i];
            }
        }

        int magicNeeded = max - k;
        if (magicNeeded <= 0)
            magicNeeded = 0; 

        Console.WriteLine(magicNeeded); 
    }
}