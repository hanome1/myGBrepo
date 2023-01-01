int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[,] GenArr2D(int rows, int columns, int firstNum) //генератор массива
{
    int[,] arr2D = new int[rows, columns];
    int i = 0, j = 0, nextNum = firstNum;
    //arr2D[0, 0] = nextNum;
    // do
    // {
    //     nextNum++;
    //     if (j < arr2D.GetLength(1) - 1 && arr2D[i, j + 1] == 0 && arr2D[i + 1, j] != nextNum - 2)
    //     {
    //         j++;
    //         arr2D[i, j] = nextNum;
    //     }
    //     else if (i < arr2D.GetLength(0) - 1 && arr2D[i + 1, j] == 0)
    //     {
    //         i++;
    //         arr2D[i, j] = nextNum;
    //     }
    //     else if (j > 0 && arr2D[i, j - 1] == 0)
    //     {
    //         j--;
    //         arr2D[i, j] = nextNum;
    //     }
    //     else if (i > 0 && arr2D[i - 1, j] == 0)
    //     {
    //         i--;
    //         arr2D[i, j] = nextNum;
    //     }
    // }
    // while (nextNum - firstNum < arr2D.GetLength(0) * arr2D.GetLength(1));
    // return arr2D;


      do
    {
        arr2D[i, j] = nextNum;
        nextNum++;
        if (j < arr2D.GetLength(1) - 1
            && arr2D[i, j + 1] == 0
            && (arr2D[i + 1, j] != nextNum - 2 || arr2D[i - 1, j] != 0))
        {
            j++;
        }
        else if (i < arr2D.GetLength(0) - 1 && arr2D[i + 1, j] == 0)
        {
            i++;
        }
        else if (j > 0 && arr2D[i, j - 1] == 0)
        {
            j--;
        }
        else if (i > 0 && arr2D[i - 1, j] == 0)
        {
            i--;
        }
        // else j++;
    }
    while (nextNum - firstNum < arr2D.GetLength(0) * arr2D.GetLength(1));
    return arr2D;

    // int dir = 1; //left to right
    // // 2 up to down
    // // 3 right to left
    // // 4 down to up
    // while (nextNum - firstNum < arr2D.GetLength(0) * arr2D.GetLength(1))
    // {
    //     nextNum++;
    //     switch (dir)
    //     {
    //         case (1):
    //             while (j < arr2D.GetLength(1) - 1 && arr2D[i, j + 1] == 0)
    //             {
    //                 j++;
    //                 arr2D[i, j] = nextNum;
    //                 nextNum++;
    //             }
    //             dir = 2;
    //             break;

    //         case (2):
    //             while (i < arr2D.GetLength(0) - 1 && arr2D[i + 1, j] == 0)
    //             {
    //                 i++;
    //                 arr2D[i, j] = nextNum;
    //                 nextNum++;
    //             }
    //             dir = 3;
    //             break;

    //         case (3):
    //             while (j > 0 && arr2D[i, j - 1] == 0)
    //             {
    //                 j--;
    //                 arr2D[i, j] = nextNum;
    //                 nextNum++;
    //             }
    //             dir = 4;
    //             break;

    //         case (4):
    //             while (i > 0 && arr2D[i - 1, j] == 0)
    //             {
    //                 i--;
    //                 arr2D[i, j] = nextNum;
    //                 nextNum++;
    //             }
    //             dir = 1;
    //             break;  
            
    //         default:
    //             dir = 0;
    //             break;
    //     }
    // }
    // return arr2D;

}

void Print2DArray(int[,] arr2D) { //печатает массив
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write(arr2D[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Print2DArray(GenArr2D(
    ReadData("Введите количество строк"),
    ReadData("Введите количество столбцов"),
    ReadData("Введите первое число")));