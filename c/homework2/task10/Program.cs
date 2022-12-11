//RANDOMIZER
//System.Random numSynth = new System.Random();
//int num = numSynth.Next(1, 100000000);
// Console.WriteLine(num);    //show me num

//USER INPUT

Console.WriteLine("input 3-digit number");
int num = int.Parse(Console.ReadLine()??"0");



if (100 <= num && num < 1000) Console.WriteLine (num/10%10);
else Console.WriteLine("incorrect number");