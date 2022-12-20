string ReadString(string str) //чтение данных, перевод в число
{
    Console.WriteLine(str);
    return (Console.ReadLine() ?? "0");
}
int ReadInt(string str)
{
    return int.Parse(ReadString(str));
}
void PrintString(string str) //вывод строки
{
    Console.Write(str);
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
int[] ArrayBuilder(int firstNum) //строим массив исходя из первого элемента
{
    int[] arr = {}; //создали пустой массив
    arr[0] = firstNum; //задали нулевой элемент
    int i = 0; //переменная индекса элемента
    string answ = ""; //строка ответа
    do 
    {
        answ = ReadString("Добавить еще элемент? (Да/Нет)");
        if (answ.ToLower() == "да")
        {
            i++;
            arr[i] = ReadInt("Введите новый элемент"); //достраиваем массив
        }
    }
    while (answ.ToLower() == "нет");
    return arr;
}
bool EvenTest(int num) //проверка на четность
{
    if (num % 2 == 0) return true;
    else return false;
}
string Counter(int[] arr) //счетчик четных элементов
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (EvenTest(arr[i])) count++;
    }
    return count.ToString();
}

int[] userArray = ArrayBuilder(ReadInt("Введите первый элемент массива"));
PrintArr(userArray);
PrintString("Четных элементов в массиве: ");
PrintString(Counter(userArray));


