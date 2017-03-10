using System;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');

        long result = 0;
        for (int i=0;i<n;i++)
        {
            result += Int32.Parse(arr_temp[i]);
        }
        Console.WriteLine(result);
    }
}