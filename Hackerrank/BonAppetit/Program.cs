using System;
class Solution
{
    static void Main(String[] args)
    {
        String[] inputs1 = Console.ReadLine().Split(' ');
        int n = Int32.Parse(inputs1[0]);
        int k = Int32.Parse(inputs1[1]);

        String[] inputs2 = Console.ReadLine().Split(' ');
        int[] inputs = new int[n];

        for (int i=0;i<n;i++)
        {
            inputs[i] = Int32.Parse(inputs2[i]);
        }

        int charged = Int32.Parse(Console.ReadLine());

        int totalBill = 0;
        for (int i=0;i<n;i++)
        {
            if (i!=k) //don't charge, Anna didn't eat here
            {
                totalBill += inputs[i];
            }
        }

        int eachBill = totalBill / 2;
        if (charged>eachBill)
        {
            Console.WriteLine(charged - eachBill);
        }
        else
        {
            Console.WriteLine("Bon Appetit");
           
        }
    }
}