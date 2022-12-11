//Считываем данные с консоли
string? numLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (numLine != null)
{
    //Парсим введенное число
    int num = int.Parse(numLine);

    int nextNum = 2;

    while (nextNum <= num) {
        Console.Write(nextNum+" ");
        nextNum = nextNum + 2;
    }

    // Выводим данные в консоль
    //Console.WriteLine(result);
}