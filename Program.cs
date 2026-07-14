Console.WriteLine("Grade Checker");
Console.WriteLine("-------------------------------------");
Console.Write("Enter student Mark: ");

float.TryParse(Console.ReadLine(), out float A);

float Mark = A;

if (Mark >= 84 && Mark <= 100)
{
    Console.WriteLine("Excellent");
}
else if (Mark >= 76)
{
    Console.WriteLine("Very Good");
}
else if (Mark >= 68)
{
    Console.WriteLine("Good");
}
else if (Mark >= 50)
{
    Console.WriteLine("Pass");
}
else if (Mark >= 35)
{
    Console.WriteLine("Fail");
}
else
{
    Console.WriteLine("Invalid Mark");
}


Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");


Console.WriteLine("Leap Year");
Console.WriteLine("-------------------------------------");
Console.Write("Enter Year: ");
short Year = short.Parse(Console.ReadLine());

bool IsLeapYear = (Year % 400 == 0) ? true :  (Year % 100 == 0) ? false :  (Year % 4 == 0) ? true : false;

switch(IsLeapYear)
{
    case true:
        Console.WriteLine( "Yes, Year [" + Year + "] is a leap year");
        break;
    case false:
        Console.WriteLine("No, Year [" + Year + "] is NOT a leap year");
        break;
}

Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");

Console.WriteLine("Random Number");
Console.WriteLine("-------------------------------------");

Random rand = new Random();
int RandomNumber = rand.Next(1, 11);

Console.WriteLine("I have chosen a number between 1 and 10.");

Console.Write("Enter your guess: ");
int guess = int.Parse(Console.ReadLine());

if (guess == RandomNumber)
{
    Console.WriteLine("Congratulations! You guessed the correct number.");
}
else
{
    Console.WriteLine("Wrong guess.");
    Console.WriteLine("The correct number was: " + RandomNumber);
}