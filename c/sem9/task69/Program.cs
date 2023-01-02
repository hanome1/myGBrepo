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

int RecMpowN(int M, int N)
{
    if (N == 1) return M;
    else return M * RecMpowN(M, N-1);
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
// string resultLine = number1<number2? RecMN(number1, number2):RecMN(number2, number1);
PrintResult(RecMpowN(number1, number2));