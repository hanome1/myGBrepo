int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
string Cubes(int n)
{
    string result = string.Empty;
    for (int i = 1; i < n; i++)
    {
        result += Math.Pow(i, 3) + ", ";
    }
    result += Math.Pow(n, 3);
    return result;
}
PrintData(Cubes(ReadData("input your number")));