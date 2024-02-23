using System;
public sealed class TwoDimensionalArray : Array, IPrint_Reverse_TwoDimensionalArray
{
    private int[,] massiv;

    public TwoDimensionalArray(int N, int M, bool choice)
    {
        massiv = new int[N, M];
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
        for (int i=0; i < massiv.GetLength(0); i+=1)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                int value = rnd.Next(0, 101);
                massiv[i,j] = value;
            }
        }
    }
    public override void NewMassiv()
    {
        Console.WriteLine("You are creating a two-dimensional array");
        for (int i=0; i < massiv.GetLength(0); i+=1)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                Console.Write($"Element[{i},{j}]:");
                massiv[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    public override void SredznachMassiv()
    {
        int sum = 0;
        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                sum += massiv[i, j];
            }
        }
        int sredzn = sum / massiv.Length;
        Console.WriteLine($"The average value of the array: {sredzn}");
        Console.WriteLine(" ");
    }
    public override void Print()
    {
        Console.WriteLine(" ");
        for (int i=0; i < massiv.GetLength(0); i+=1)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                if(j == massiv.GetLength(1)-1)
                {
                    Console.WriteLine(massiv[i,j]);
                }
                else
                {
                    Console.Write(massiv[i,j]);
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine(" ");
    }


    public void Print_Rev()
    {
        for (int i=0; i < massiv.GetLength(0); i+=1)
        {
            if (i%2 != 0)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    if(j == massiv.GetLength(1)-1)
                    {
                        Console.WriteLine(massiv[i,j]);
                    }
                    else
                    {
                        Console.Write(massiv[i,j]);
                        Console.Write(" ");
                    }
                }
            }
            else
            {
                for (int j = massiv.GetLength(1)-1; j >= 0; j= j - 1)
                {
                    if(j == 0)
                    {
                        Console.WriteLine(massiv[i,j]);
                    }
                    else
                    {
                        Console.Write(massiv[i,j]);
                        Console.Write(" ");
                    }
                }
            }
        }
        Console.WriteLine(" ");
    }
}
