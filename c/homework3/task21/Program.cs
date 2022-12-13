int ReadData(string msg) {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
} 
void PrintData(string msg, double result) {
    Console.WriteLine(msg+result);
}
double Length(int x1, int y1, int z1, int x2, int y2, int z2) {
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2)+Math.Pow((y1 - y2), 2)+Math.Pow((z1 - z2), 2));
    return result;
}
int x1 = ReadData("input coordinate x1");
int y1 = ReadData("input coordinate y1");
int z1 = ReadData("input coordinate z1");
int x2 = ReadData("input coordinate x2");
int y2 = ReadData("input coordinate y2");
int z2 = ReadData("input coordinate z2");
PrintData("distance between two points is ", Length(x1, y1, z1, x2, y2, z2));