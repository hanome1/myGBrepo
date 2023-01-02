
// ---------------------------------------------------------------------
//                                 Задача 64
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int LineGenRec(int num)
{
    if (num % 10 == 0) return num;
    else return num % 10 + LineGenRec(num/10);
}

int number = ReadData("Введите число N: ");
int resultLine = LineGenRec(number);
PrintResult(resultLine);