System.Random numSynth = new System.Random(); //randomizer created

int num = numSynth.Next(100,1000);
Console.WriteLine (num);    //random xxx num

int firstDigit = num / 100;
int secondDigit = num % 10;

int result = firstDigit * 10 + secondDigit;
Console.WriteLine (result);