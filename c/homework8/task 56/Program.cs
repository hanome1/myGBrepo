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
// void Print2DArray(int[,] arr2D)
// {
//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//             Console.Write(arr2D[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
int[,] AddSumInRowTo2DArray(int[,] arr2D) // припишем к каждой строке сумму элементов
{
    int[,] newArr = new int[arr2D.GetLength(0), arr2D.GetLength(1) + 1];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        int stringSum = 0;
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            newArr[i, j] = arr2D[i, j];
            stringSum += arr2D[i, j];
        }
        newArr[i, arr2D.GetLength(1)] = stringSum;
    }
    return newArr;
}

void Print2DArray(int[,] arr2D) //печатает массив с последним столбцом желтым
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1)-1; j++)
        {
            Console.Write(arr2D[i, j] + " ");
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(arr2D[i, arr2D.GetLength(1)-1]);
        Console.ResetColor();
        Console.WriteLine();
    }
}

// int NumStringWithMinSum(int[,] arr2D)
// {

//     int minStringSum = 0;
//     int numOfString = 0;
//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         int stringSum = 0;
//         for (int j = 1; j < arr2D.GetLength(1); j++) stringSum += arr2D[i, j];
//         if (i == 0) minStringSum = stringSum;
//         else if (stringSum < minStringSum)
//         {
//             minStringSum = stringSum;
//             numOfString = 1 + i;
//         }
//     }
//     return numOfString;
// }

int NumStringWithMinSum(int[,] arr2D) //дает номер строки
{
    int numOfString = 0;
    int min = arr2D[0,arr2D.GetLength(1)-1];
    for (int i = 1; i < arr2D.GetLength(0); i++)
    {
        if (arr2D[i,arr2D.GetLength(1)-1] < min) {
            min = arr2D[i,arr2D.GetLength(1)-1];
            numOfString = i;
    }}
    return numOfString+1;
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int[,] userArray = AddSumInRowTo2DArray(GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите нижний предел"),
    ReadData("Введите верхний предел")));

Print2DArray(userArray);

int minNum = NumStringWithMinSum(userArray);
PrintData($"\nНаименьшая сумма элементов в строке {minNum} ({userArray[minNum-1, userArray.GetLength(1)-1]}).");
