int ReadData(string msg) //преобразует строку в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, int result) //выводит сообщение и вычисленный результат
{
    Console.WriteLine(msg + result);
}
double CalculateSum (int num) {        //вычисляет сумму цифр
    double sum = 0;
    while (num>0) {
        sum += num%10;
        num /= 10;
    }
    return sum;
}

//HARD PART

int CalculateSumThroughArray (int num) {
    int[] arr = num.ToIntArray();
    
    return arr;
}

int number = ReadData("input your number");
DateTime d1 = DateTime.Now;
int length1 = CalculateSum(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int length2 = CalculateSumThroughArray(number);
Console.WriteLine(DateTime.Now - d2);

PrintData("sum of your number's digits is ", CalculateSum(number));