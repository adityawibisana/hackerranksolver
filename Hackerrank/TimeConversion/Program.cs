using System;
class Solution
{ 
    static void Main(String[] args)
    {
        string time = Console.ReadLine();

        bool isPM = time.Contains("PM");
        time = time.Replace("AM", "").Replace("PM", "");

        String [] timesStr = time.Split(':');
        //remove the 0 at the beginning
        for (int i=0;i<timesStr.Length;i++)
        {
            if (timesStr[i].StartsWith("0"))
                timesStr[i] = timesStr[i].Substring(1, 1);
        } 

        int hour = Int32.Parse(timesStr[0]);

        hour = hour == 12 ? 0 : hour;

        hour = isPM ? hour + 12 : hour;  

        String sHour = hour < 10 ? "0" + hour : hour.ToString();

        int minute = Int32.Parse(timesStr[1]);
        String sMinute = minute < 10 ? "0" + minute : minute.ToString();

        int second = Int32.Parse(timesStr[2]);
        String sSecond = second < 10 ? "0" + second : second.ToString();

        Console.WriteLine(String.Format("{0}:{1}:{2}", sHour, sMinute, sSecond)); 
    }
}