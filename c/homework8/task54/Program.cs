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

int[,] Sort2DArray(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        int temp = 0;
        for (int k = 1; k < arr2D.GetLength(1); k++)
        {

            for (int j = 1; j < arr2D.GetLength(1); j++)
            {
                if (arr2D[i, j] > arr2D[i, j - 1])
                {
                    temp = arr2D[i, j];
                    arr2D[i, j] = arr2D[i, j - 1];
                    arr2D[i, j - 1] = temp;
                }
            }
        }
    }
    return arr2D;
}

int[,] userArray = (GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите нижний предел"),
    ReadData("Введите верхний предел")));
Print2DArray(userArray);
Console.WriteLine();
Print2DArray(Sort2DArray(userArray));
