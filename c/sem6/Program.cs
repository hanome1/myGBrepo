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
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void Print2DArrayColor(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}
Print2DArray(GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите нижний предел"),
    ReadData("Введите верхний предел")));