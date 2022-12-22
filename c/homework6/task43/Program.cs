int ReadData(string msg) {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
} 
void PrintData(string res) {
    Console.WriteLine(res);
}
string CrossFinder(int k1, int b1, int k2, int b2) {
    string msg = "";
    if (k1 == k2) msg = "Прямые не пересекутся";
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * b2 - k2 * b1) / (k1 - k2);
        msg = $"Прямые пересекутся в точке ({x}; {y})";
    }
    return msg;
}
// int k1 = ReadData("введите k1");
// int b1 = ReadData("введите k1");
// int k2 = ReadData("введите k2");
// int b2 = ReadData("введите b2");
PrintData(CrossFinder(ReadData("введите k1"), ReadData("введите b1"), 
                        ReadData("введите k2"), ReadData("введите b2")));