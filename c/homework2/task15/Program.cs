//RANDOMIZER
//System.Random numSynth = new System.Random();
//int num = numSynth.Next(1, 8);
// Console.WriteLine(num);    //show me num


//USER INPUT
Console.WriteLine("input a number of day of the week");
int num = int.Parse(Console.ReadLine()??"0");


if (num >= 1 && num <= 5) Console.WriteLine("this is not a day-off");
else if (num == 6 || num == 7) Console.WriteLine("this is a day-off!");
else Console.WriteLine("incorrect number of day");