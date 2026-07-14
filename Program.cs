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
