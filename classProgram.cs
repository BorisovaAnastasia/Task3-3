using System;

class Program
{
    static void Main()
    {
        IBaseArray[] mass = new Array[3];
        mass[0] = new OneDimensionalArray(4, false);
        mass[1] = new TwoDimensionalArray(3, 2, false);
        mass[2] = new SteppedArray(4, false);
        for (int i = 0; i < 3; i++)
        {
            mass[i].Print();
            mass[i].SredznachMassiv();
        }

        // mass[0].Print();
        // ((INo_Dub_OneDimensional)mass[0]).No_Dub_Array();
        // mass[0].Print();
        // mass[1].Print();
        // ((IPrint_Reverse_TwoDimensionalArray)mass[1]).Print_Rev();
        // mass[2].Print();
        // ((IEdit_SteppedArray)mass[2]).EditArray();
        // mass[2].Print();

        IPrint[] massPrint = new IPrint[4];
        massPrint[0] = mass[0];
        massPrint[1] = mass[1];
        massPrint[2] = mass[2];
        massPrint[3] = new Week();

        for (int i = 0; i < 4; i++)
        {
            massPrint[i].Print();
        }
    }
}