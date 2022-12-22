int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
double[,] GenArr2D(int rows, int columns) //генератор массива
{
    //Random rnd = 
    double[,] arr2D = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            // arr2D[i, j] = new Random().NextDouble() + new Random().Next(0,10);
            arr2D[i, j] = Math.Round((new Random().NextDouble() + new Random().Next(0, 10)), 3);
        }
    }
    return arr2D;
}
void Print2DArray(double[,] arr2D)
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

void Print2DArrayColor(double[,] matrix)
{
    int[] usedColors = new int[16]; //массив хранит индексы использованных цветов
    int colorIndex = 0; //индекс цвета
    int usedColorIndex = 0; //индекс использованного цветв
    bool colorMatch = false; //совпадает ли цвет с использованным
    bool blackMatch = false; //отдельная проверка на черный цвет с индексом 0
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            do
            {
                colorMatch = false; //обнуляем значиние проверки на цвет
                colorIndex = new System.Random().Next(0, 16); //генерируем индекс цвета
                for (int k = 0; k < usedColors.Length; k++) //выпускает из цикла только с новым индексом цвета
                {
                    if (colorIndex == 0 && blackMatch == false)  //разово допускает черный цвет
                    {
                        blackMatch = true;
                        break;
                    }
                    if (usedColors[k] == colorIndex) colorMatch = true; 
                }
            }
            while (colorMatch == true);

            usedColors[usedColorIndex] = colorIndex; //сохранем индекс цвета в наш массив
            usedColorIndex++;

            Console.ForegroundColor = col[colorIndex];
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    // PrintArr(usedColors); 
}
Print2DArray(GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов")));

Console.WriteLine();
Print2DArrayColor(GenArr2D(4, 4));



void PrintArr(int[] arr)  //печатаем массив красиво
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}