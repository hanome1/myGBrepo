// string ReadString(string str) //чтение данных, перевод в число
// {
//     Console.WriteLine(str);
//     return (Console.ReadLine() ?? "0");
// }
// int ReadInt(string str)
// {
//     return int.Parse(ReadString(str));
// }
// void PrintString(string str) //вывод строки
// {
//     Console.Write(str);
// }
// void PrintArr(int[] arr)  //печатаем массив красиво
// {
//     Console.Write("\n[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }
// int[] ArrayBuilder(int firstNum) //строим массив исходя из первого элемента
// {
//     int[] arr = {}; //создали пустой массив
//     arr[0] = firstNum; //задали нулевой элемент
//     int i = 0; //переменная индекса элемента
//     string answ = ""; //строка ответа
//     do 
//     {
//         answ = ReadString("Добавить еще элемент? (Да/Нет)");
//         if (answ.ToLower() == "да")
//         {
//             i++;
//             arr[i] = ReadInt("Введите новый элемент"); //достраиваем массив
//         }
//     }
//     while (answ.ToLower() != "нет");
//     return arr;
// }
// bool EvenTest(int num) //проверка на четность
// {
//     if (num % 2 == 0) return true;
//     else return false;
// }
// string Counter(int[] arr) //счетчик четных элементов
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (EvenTest(arr[i])) count++;
//     }
//     return count.ToString();
// }

// int[] userArray = ArrayBuilder(ReadInt("Введите первый элемент массива"));
// PrintArr(userArray);
// PrintString("Четных элементов в массиве: ");
// PrintString(Counter(userArray));


int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string res, int number) //вывод массива, сообщения и числа
{
    Console.WriteLine(res + number);
}
int CountPositive(int n) //считает положительные числа в массиве и печатает его. требует указать кол-во элементов (n)
{
    int count = 0; 
    int[] arr = new int[n];
    int i = 0; //индекс
    while (n>0)
    {
        arr[i] = ReadData("Введите число");
        if (arr[i] > 0) count++;
        i++;
        n--;
    }
    PrintArr(arr);
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

PrintData("\nположительных чисел в массиве: ", CountPositive(ReadData("Введите длину массива")));