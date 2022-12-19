int ReadData(string msg) //преобразует строку в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, double result) //выводит сообщение и вычисленный результат
{
    Console.WriteLine(msg + result);
}
double Pow(int num, int pow) //вычисляет число в степени
{
    double res = Math.Pow(num, pow);
    return res;
}


PrintData("power is: ", Pow(ReadData("input your number"), (ReadData("input pow"))));

// int num = ReadData("input your number");
// int pow = ReadData("input pow");
// PrintData("power is: ", Pow(num, pow));

//вопрос: какая из записей более правильная? какая проще читается?