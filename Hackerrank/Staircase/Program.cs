using System;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());        
        int pointer = n-1;
        for (int i=0;i<n;i++)
        {    
            for (int j=0;j<n;j++)
            {
                if (j<pointer)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }
            }
            pointer--;
            Console.WriteLine("");
        } 
    }
}