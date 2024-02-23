using System;

public class Week : IPrint
{
   // private string[] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};


   // public void Print()
   // {
   //     Console.WriteLine(" ");
   //     for (int i = 0; i < week.Length; i++)
   //     {
   //         Console.WriteLine(week[i]);
   //     }
   //     Console.WriteLine(" ");
   // }

    private string week = "Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday";
    public void Print()
    {
        Console.WriteLine(week);
    }
}