int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(double prefix)
{
    Console.WriteLine(prefix);
}

double Ackermann(double m, double n)
{
    // if (n == 0) return m + 1;
    // else if (m == 0) return Ackerman(n - 1, 1);
    // else return Ackerman(n - 1, Ackerman(n, m - 1));

    if(m > 0)
        {
            if (n > 0)
                return Ackermann(m - 1, Ackermann(m, n - 1));
            else if (n == 0)
                return Ackermann(m - 1, 1);
        }
        else if(m == 0)
        {
            if(n >= 0) 
                return n + 1;
        }

        throw new System.ArgumentOutOfRangeException();
}

double number1 = ReadData("Введите число M: ");
double number2 = ReadData("Введите число N: ");
// int resultLine = number1 < number2 ? RecSumMtoN(number1, number2) : RecSumMtoN(number2, number1);
PrintResult(Ackermann(number1, number2));