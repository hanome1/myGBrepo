int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[,] GenArr2D(int rows, int columns, int bottomLim, int topLim) //генератор массива
{
    Random rnd = new Random();
    int[,] arr2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr2D[i, j] = rnd.Next(bottomLim, topLim + 1);
        }
    }
    return arr2D;
}
void Print2DArray(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write(arr2D[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintMidCol(int[,] arr)
{
    double res = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            res += arr[i,j];
        }
        Console.WriteLine($"Среднее арифметическое чисел в стобце {j+1}: {res/arr.GetLength(0)}");
    }
}

int[,] userArray = (GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите нижний предел"),
    ReadData("Введите верхний предел")));
Print2DArray(userArray);
Console.WriteLine();
PrintMidCol(userArray);
