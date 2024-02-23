using System;
public sealed class SteppedArray : Array, IEdit_SteppedArray
{
    private int[][] j_array;

    public SteppedArray(int N, bool choice)
    {
        j_array = new int[N][];
        if (choice)
        {
            NewMassivR();
        }
        else
        {
            NewMassiv();
        }
    }
    public override void NewMassivR()
    {
        Random rnd = new Random();
        for (int i = 0; i < j_array.GetLength(0); i++)
        {
            int len = rnd.Next(1, 11);
            j_array[i] = new int[len];
            for (int j = 0; j < len; j++)
            {
                int value = rnd.Next(0, 101);
                j_array[i][j] = value;
            }
        }
    }
    public override void NewMassiv()
    {
        Console.WriteLine("You are creating a stepped array");
        for (int i = 0; i < j_array.GetLength(0); i++)
        {
            Console.Write($"The number of items in a line {i+1}: ");
            int len = Convert.ToInt32(Console.ReadLine());
            j_array[i] = new int[len];
            for (int j = 0; j < len; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                j_array[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public override void Print()
    {
        Console.WriteLine(" ");
        for (int i = 0; i<j_array.Length;i++)
        {
            for (int j = 0; j < j_array[i].Length; j++)
            {
                if(j == j_array[i].Length-1)
                {
                    Console.WriteLine(j_array[i][j]);
                }
                else
                {
                    Console.Write(j_array[i][j]);
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine(" ");
    }
    public override void SredznachMassiv()
    {
        int sum = 0;
        for (int i = 0; i<j_array.Length;i++)
        {
            for (int j = 0; j < j_array[i].Length; j++)
            {
                sum += j_array[i][j];
            }
        }
        int SredznAr = sum / j_array.Length;
        Console.WriteLine($"The average value of the array: {SredznAr}");
    }

    public void EditArray()
    {
        for (int i = 0; i<j_array.Length;i++)
        {
            for (int j = 0; j < j_array[i].Length; j++)
            {
                if (j_array[i][j] % 2 == 0)
                {
                    j_array[i][j] = i*j;
                }
            }
        }
    }
}