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

int[,] Multiply2DArray(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            throw new Exception("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (var i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                // matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
}

Console.WriteLine("Первая матрица:");

int[,] userArray1 = (GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите нижний предел"),
    ReadData("Введите верхний предел")));



Console.WriteLine("\nВторая матрица:");

int[,] userArray2 = (GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите нижний предел"),
    ReadData("Введите верхний предел")));

Console.WriteLine("\nПервая матрица:");
Print2DArray(userArray1);

Console.WriteLine("Вторая матрица:");
Print2DArray(userArray2);

Console.WriteLine("Произведение матриц: ");
Print2DArray(Multiply2DArray(userArray1, userArray2));
