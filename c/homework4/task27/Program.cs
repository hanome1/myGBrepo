int ReadData(string msg) //преобразует строку в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, int result) //выводит сообщение и вычисленный результат
{
    Console.WriteLine(msg + result);
}
int CalculateSum (int num) {        //вычисляет сумму цифр
    int sum = 0;
    while (num>0) {
        sum += num%10;
        num /= 10;
    }
    return sum;
}
//char [] number = ReadData("input your number").toCharArray;
PrintData("sum of your number's digits is ", CalculateSum(ReadData("input your number")));