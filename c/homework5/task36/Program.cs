int ReadData(string msg) //чтение данных, перевод в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(int[] arr, string res, int number) //вывод массива, сообщения и числа
{
    PrintArr(arr);
    Console.WriteLine(res + number);
}
int[] GenArr(int len) { //генератор массива
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}
int Counter (int[] arr) { //счетчик элементов на нечетных позициях
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2) {
    sum += arr[i];
    }
    return sum;
}
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
int[] array = GenArr(ReadData("Введите длину массива."));
PrintData(array,"\n сумма элементов на нечетных позициях: ",Counter(array));

