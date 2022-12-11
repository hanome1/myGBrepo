//Считываем данные с консоли
string? numLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (numLine != null)
{
    //Парсим введенное число
    int num = int.Parse(numLine);

    //переменная результата
    string result = string.Empty;

    //проверяем
    if (num % 2 == 0)
    {
        result = "число четное";
    }
    else
    {
        result = "число нечетное";
    }

    // Выводим данные в консоль
    Console.WriteLine(result);
}