using System;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < n; a0++)
        {
            int grade = Convert.ToInt32(Console.ReadLine()); 
            if (grade < 38)
            {
                Console.WriteLine(grade);
            }
            else
            {
                if ((grade+1)%5==0)
                {
                    Console.WriteLine(grade + 1);
                }
                else if ((grade+2)%5==0)
                {
                    Console.WriteLine(grade + 2);
                }
                else
                {
                    Console.WriteLine(grade);
                }
            }
        }
    }
}