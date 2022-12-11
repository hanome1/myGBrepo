int ReadData(string msg) {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
} 
void PrintData(string msg, double result) {
    Console.WriteLine(msg+result);
}
double Length(int x1, int y1, int x2, int y2) {
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return result;
}
int x1 = ReadData("input coordinate x1");
int y1 = ReadData("input coordinate y1");
int x2 = ReadData("input coordinate x2");
int y2 = ReadData("input coordinate y2");
PrintData("distance between two points is ", Length(x1, y1, x2, y2));
