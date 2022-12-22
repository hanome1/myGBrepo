int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
int[,] GenArr2D(int rows, int columns) //генератор массива
{
    Random rnd = new Random();
    int[,] arr2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr2D[i, j] = rnd.Next(0, 100);
        }
    }
    return arr2D;
}
void Print2DArray(int[,] arr2D, int numRow, int numCol)
{
    bool existCheck = false; //проверка существует ли элемент пользователя в массиве
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (i == numRow - 1 && j == numCol - 1)
            {
                Console.ForegroundColor = col[new System.Random().Next(0, 16)]; //выделить случайным цветом
                existCheck = true;
            }
            Console.Write(arr2D[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    if (existCheck == false) Console.WriteLine($"Элемента с индексом [{numRow}, {numCol}]  в массиве нет");
}


int userRows = ReadData("Введите количество строк");
int userColumns = ReadData("Введите количество столбцов");
int userRow = ReadData("Введите индекс строки");
int userColumn = ReadData("Введите индекс столбца");

Print2DArray(GenArr2D(userRows, userColumns), userRow, userColumn);
Print2DArray(GenFibo(userRows, userColumns), userRow, userColumn);

int[,] GenFibo(int rows, int columns) //генератор массива
{
    int[,] arr2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == 0 && j == 0)
            {
                arr2D[i, j] = 0;
            }

            else if (i == 0 && j == 1)
            {
                arr2D[i, j] = 1;
            }

            else if (j >= 2)
            {

                arr2D[i, j] = arr2D[i, j - 1] + arr2D[i, j - 2];
            }
            else
            {
                arr2D[i, j] = arr2D[i - 1, arr2D.GetLength(1)] + arr2D[i - 1 + j, Math.Abs(j-1) * arr2D.GetLength(1)- Math.Abs(j-1)];
            }
        }
    }

    return arr2D;
}