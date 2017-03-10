using System;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = new int[arr_temp.Length];

        double positive = 0, negative = 0, zero = 0;
        for (int i=0;i<arr.Length;i++)
        {
            arr[i] = Int32.Parse(arr_temp[i]);
            if (arr[i]>0)
            {
                positive++;
            }
            else if (arr[i]==0)
            {
                zero++;
            }
            else
            {
                negative++;
            }
        }

        positive = positive / n;
        negative = negative / n;
        zero = zero / n;

        Console.WriteLine(positive.ToString("N6"));
        Console.WriteLine(negative.ToString("N6"));
        Console.WriteLine(zero.ToString("N6"));
    }
}
