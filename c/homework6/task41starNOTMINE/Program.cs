// * Найдите площадь треугольника образованного пересечением 3 прямых 
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double coefficientK1 = ReadData("Input number K1: ");
double coefficientB1 = ReadData("Input number B1: ");
double coefficientK2 = ReadData("Input number K2: ");
double coefficientB2 = ReadData("Input number B2: ");
double coefficientK3 = ReadData("Input number K3: ");
double coefficientB3 = ReadData("Input number B3: ");
// Вводим перменную для строки с координатами.
string dots = CrossPoint1(coefficientK1, coefficientB1, coefficientK2, coefficientB2, coefficientK3, coefficientB3);
// Разбиваем строку на строковый массив.
string[] dotsArr = dots.Split(';');
// Преобразуем строковое значение коррдинат в вещественный тип, чтобы использовать в дальнейших рассчетах.
double X1 = double.Parse(dotsArr[0]);
double Y1 = double.Parse(dotsArr[1]);
double X2 = double.Parse(dotsArr[2]);
double Y2 = double.Parse(dotsArr[3]);
double X3 = double.Parse(dotsArr[4]);
double Y3 = double.Parse(dotsArr[5]);
PrintData($"Cross points of 3 lines: X1= {X1}; Y1= {Y1}, X2= {X2}; Y2= {Y2}, X3= {X3}; Y3= {Y3}");
double sideA = TriangleSideA(X1, Y1, X2, Y2);
double sideB = TriangleSideB(X2, Y2, X3, Y3);
double sideC = TriangleSideC(X3, Y3, X1, Y1);
PrintData($"The length of triangle sides: A= {sideA}; B= {sideB}, C= {sideC}");
PrintData($"The square of triangle: S= {SquareTriangle(sideA, sideB, sideC)}");

// Метод считывания введенных данных.
double ReadData(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}
// Метод вывода данных.
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
// Находим точки пересечния трех прямых в одном методе, результат выводим с строковом виде.
string CrossPoint1(double k1, double b1, double k2, double b2, double k3, double b3)
{
    string res = string.Empty;
    double coorX1 = (b2 - b1) / (k1 - k2);
    double coorY1 = (k1 * b2 - k2 * b1) / (k1 - k2);
    double coorX2 = (b3 - b2) / (k2 - k3);
    double coorY2 = (k2 * b3 - k3 * b2) / (k2 - k3);
    double coorX3 = (b1 - b3) / (k3 - k1);
    double coorY3 = (k3 * b1 - k1 * b3) / (k3 - k1);
    return res = $"{coorX1}; {coorY1};{coorX2};{coorY2};{coorX3};{coorY3}";
}
//Находим стороны треугольника, разбила на 3 отдельных метода, чтобы получить сразу переменные в double.
double TriangleSideA(double x1, double y1, double x2, double y2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return result;
}
double TriangleSideB(double x2, double y2, double x3, double y3)
{
    double result = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
    return result;
}
double TriangleSideC(double x3, double y3, double x1, double y1)
{
    double result = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
    return result;
}
// Находим площадь треугольника через полумериметр (p=(a + b + c) / 2 )сторон и длины сторон.
double SquareTriangle(double a, double b, double c)
{
    double squareT = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
    return squareT;
}