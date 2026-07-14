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

