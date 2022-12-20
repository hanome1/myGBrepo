﻿int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(int[] arr, string res, int number) //вывод массива, сообщения и числа
{
    PrintArr(arr);
    Console.WriteLine(res + number);
}
int[] GenArr(int len)
{ //генератор массива
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}
// int Counter (int[] arr) { //счетчик четных элементов
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++) {
//     if (arr[i] % 2 == 0) count++;
//     }
//     return count;
// }
bool EvenTest(int num) //проверка на четность
{
    if (num % 2 == 0) return true;
    else return false;
}
int Counter(int[] arr) //счетчик четных элементов
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (EvenTest(arr[i])) count++;
    }
    return count;
}

void PrintArr(int[] arr)  //печатаем массив красиво
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] SortBubble(int[] arr) //сортировка массива пузырьком
{
    int temp = 0; //временный контейнер для перетасовки
    for (int j = 0; j < arr.Length - 1; j++)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
    }
    return arr;
}

int[] array = GenArr(ReadData("Введите длину массива:"));
PrintData(array, "\nчетных элементов в массиве: ", Counter(array));

Console.WriteLine("\nОтсортированный массив:");
PrintArr(SortBubble(array));