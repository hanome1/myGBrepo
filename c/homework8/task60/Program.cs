int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

List<int> twoDigNums = new List<int>();
for (int i = 0; i < 90; i++)
{
    twoDigNums.Add(10+i);
}

int[,,] GenArr3D(int rows, int columns, int pieces) //генератор массива
{
    Random rnd = new Random();
    int[,,] arr3D = new int[rows, columns, pieces];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pieces; k++)
            {
                arr3D[i, j, k] = GenNum(twoDigNums);
            }
        }
    }
    return arr3D;
}

int GenNum(List<int> nums) {
    int index = new Random().Next(0, nums.Count);
    return nums[index];
    nums.RemoveAt(index);
}
void Print3DArrayToRawsWithIndex(int[,,] arr3D) //печатает массив с последним столбцом желтым
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write(arr3D[i, j, k] + $"({i},{j},{k})    ");
            }
            Console.WriteLine();
        }
    }
}
// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }
Print3DArrayToRawsWithIndex(GenArr3D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите глубину")));

// Print2DArray(userArray);

// int minNum = NumStringWithMinSum(userArray);
// PrintData($"\nНаименьшая сумма элементов в строке {minNum} ({userArray[minNum-1, userArray.GetLength(1)-1]}).");
