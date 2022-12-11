//Считываем данные с консоли
string? numALine = Console.ReadLine();
string? numBLine = Console.ReadLine();
string? numCLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (numALine != null && numBLine != null && numCLine != null)
{

    //Парсим введенное число
    int numA = int.Parse(numALine);
    int numB = int.Parse(numBLine);
    int numC = int.Parse(numCLine);
    
    //переменная максимума
    int max = numA;
    //сравниваем
    if (numB>max) {
        max = numB;
    }
    if (numC>max) {
        max = numC;
    }
    // Выводим данные в консоль
    Console.WriteLine(max);
}
//из первого семинара не понял как использовать индекс в массиве, с массивом наверное было бы интереснее