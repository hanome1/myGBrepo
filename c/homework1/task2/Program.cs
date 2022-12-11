//Считываем данные с консоли
string? numALine = Console.ReadLine();
string? numBLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (numALine != null && numBLine != null)
{

    //Парсим введенное число
    int numA = int.Parse(numALine);
    int numB = int.Parse(numBLine);
    
    //сравниваем
    string check = string.Empty;
    if (numA>numB) {
        check = "Число А("+numA+") больше числа В("+numB+")";
    }
    else if (numB>numA) {
        check = "Число А("+numA+") меньше числа В("+numB+")";
    }
    else
        check = "Числа А("+numA+") и В("+numB+")равны";
    // Выводим данные в консоль
    Console.WriteLine(check);
}