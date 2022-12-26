int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[,] GenArr2D(int rows, int columns, int firstNum) //генератор массива
{
    int[,] arr2D = new int[rows, columns];
    int i = 0, j = 0, nextNum = firstNum;
    arr2D[0, 0] = nextNum;
    do
    {
        nextNum++;
        if (j < arr2D.GetLength(1) - 1 && arr2D[i, j+1] == 0 && arr2D[i+1,j] != nextNum-2)
        {
            j++;
            arr2D[i, j] = nextNum;
        }
        else if (i < arr2D.GetLength(0) - 1 && arr2D[i + 1, j] == 0)
        {
            i++;
            arr2D[i, j] = nextNum;
        }
        else if (j > 0 && arr2D[i, j - 1] == 0)
        {
            j--;
            arr2D[i, j] = nextNum;
        }
        else if (i > 0 && arr2D[i - 1, j] == 0)
        {
            i--;
            arr2D[i, j] = nextNum;
        }
    }
    while (nextNum - firstNum < arr2D.GetLength(0) * arr2D.GetLength(1));
    return arr2D;
}

void Print2DArray(int[,] arr2D) //печатает массив с последним столбцом желтым
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
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
Print2DArray(GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите первое число")));