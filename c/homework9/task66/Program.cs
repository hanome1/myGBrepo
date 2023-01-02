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

int RecSumMtoN(int m, int n)
{
    if (m >= n) return n;
    else return m + RecSumMtoN(m+1, n);
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int resultLine = number1<number2? RecSumMtoN(number1, number2):RecSumMtoN(number2, number1);
PrintResult(resultLine);