using System;
class Solution
{
    static void Main(String[] args)
    {
        String[] inputsStr = Console.ReadLine().Split(' ');
        int[] inputs = new int[5];

        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        long total = 0;
        for (int i=0;i<inputsStr.Length;i++)
        {
            inputs[i] = Int32.Parse(inputsStr[i]);
            if (inputs[i] < min)
                min = inputs[i];
            if (inputs[i] > max)
                max = inputs[i];
            total += inputs[i];
        }

        Console.WriteLine((total-max)+" "+(total-min)); 
    }
}