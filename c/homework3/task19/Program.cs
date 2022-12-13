int ReadData(string msg) {
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
} 
void PrintData(string msg) {
    Console.WriteLine(msg);
}
string Check(int number){
    if (number/10000 == number%10 && number/1000%10 == number/10%10) return "yes";
    else return "no";
}
//int number = ReadData("enter 5-digit number");

PrintData(Check(ReadData("enter 5-digit number")));
