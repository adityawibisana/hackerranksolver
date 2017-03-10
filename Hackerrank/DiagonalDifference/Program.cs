using System;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0; a_i < n; a_i++)
        {
            a[a_i] = new int[n];
            string[] a_temp = Console.ReadLine().Split(' ');            
            for (int i=0;i<a_temp.Length;i++)
            {                
                a[a_i][i] = Int32.Parse(a_temp[i]);
            } 
        }

        //count the primary diagonal sum
        int primarySum = 0;        
        int pointer = 0;
        for (int i = 0; i < n; i++)
        {            
            for (int j=0;j<n;j++)
            {
                if (i==j && i==pointer)
                {
                    primarySum += a[i][j];
                    pointer++;
                    continue;
                }
            } 
        }        


        //count the secondary diagonal sum
        int secondarySum = 0;
        pointer = n-1; // -1 because it is index
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == pointer)
                {
                    secondarySum += a[i][pointer];
                    pointer--;
                    continue;
                }
            }
        }

        int result = primarySum - secondarySum;
        result = Math.Abs(result);

        Console.WriteLine(result);
    }
}