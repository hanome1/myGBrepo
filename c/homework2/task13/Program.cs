//RANDOMIZER
//System.Random numSynth = new System.Random();
//int num = numSynth.Next(1, 100000000);
// Console.WriteLine(num);    //show me num

//USER INPUT
int num = int.Parse(Console.ReadLine()??"0");




int temp = num; //will be num without last digit
while (temp/1000 != 0) temp = temp/10;
Console.WriteLine(temp%10);
