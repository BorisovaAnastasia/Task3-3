using System;

public sealed class OneDimensionalArray : Array, INo_Dub_OneDimensional
{
    private int[] massiv;

    public OneDimensionalArray(int N, bool choice)
    {
        massiv = new int[N];
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
        for (int i = 0; i < massiv.Length; i++)
        {
            int value = rnd.Next(101);
            int x = value;
            massiv[i] = x;
        }
    }
    public override void NewMassiv()
    {
        Console.WriteLine("You are creating a one-dimensional array");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.Write($"Element {i}: ");
            int x = Convert.ToInt32(Console.ReadLine());
            massiv[i] = x;
        }
    }
    public override void Print()
    {
        Console.WriteLine(" ");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine(massiv[i]);
        }
        Console.WriteLine(" ");
    }


    public override void SredznachMassiv()
    {
        int sum = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            sum += massiv[i];
        }
        int sredzn = sum / massiv.Length;
        Console.WriteLine($"The average value of the array: {sredzn}");
        Console.WriteLine(" ");
    }

    public void No_Dub_Array()
    {
        int newMassLength = massiv.Length;
        for(int i = 0; i < massiv.Length; i++)
        {
            for(int j = i; j < massiv.Length; j++)
            {
                if(massiv[i] == massiv[j] && i != j)
                {
                    newMassLength--;
                    break;
                }
            }
        }
        int[] NewMass = new int[newMassLength];
        for(int i = 0; i < NewMass.Length; i++)
        {
            NewMass[i] = int.MinValue;
        }
        int c = 0;
        for(int i = 0; i < massiv.Length; i++)
        {
            if(!Ex(massiv[i], NewMass))
            {
                NewMass[c] = massiv[i];
                c++;
            }
        }
        massiv = NewMass;
    }


    private static bool Ex(int val, int[] mass)
    {
        for(int i=0; i < mass.Length; i++)
        {
            if (mass[i] == val)
            {
                return true;
            }
        }
        return false;
    }
}
