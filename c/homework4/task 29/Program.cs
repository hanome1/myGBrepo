﻿int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int len, int bottomLimit, int topLimit)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(bottomLimit, topLimit+1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

// int arrLen = ReadData("Введите длину массива.");
// int arbot = 3;
// int artop = 5;
// int[] arr = GenArr(arrLen, arbot, artop);

// PrintData("Сгененрированный массив:", arr);

PrintData("Сгененрированный массив:", GenArr(ReadData("Введите длину массива."), 
                                            ReadData("Введите нижний предел."),
                                            ReadData("Введите нижний предел.")));