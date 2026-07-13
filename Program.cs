<<<<<<< HEAD
﻿Console.WriteLine("Calculator");
Console.WriteLine("-------------------------------------");
Console.WriteLine("Enter Number 1");
double Number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Number 2");
double Number2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Your Arithmetic Operators ");
char Operator = char.Parse(Console.ReadLine());
double Result = 0;
if (Operator == '+')
    Result = Number1 + Number2;
else if (Operator == '-')
    Result = Number1 - Number2;
else if (Operator == '*')
    Result = Number1 * Number2;
else if (Operator == '/' && Number2 != 0)
        Result= Number1 / Number2;
else if (Operator == '%')
    Result = Number1 % Number2;

if(Operator == '/' && Number2 == 0)
    Console.WriteLine("Math Erorr!");

Console.WriteLine("The Result = " + Result);

Console.WriteLine("------------------------------------");
Console.WriteLine("------------------------------------");

Console.WriteLine("JOD/USD");
Console.WriteLine("-------------------------------------");
const double JOD = 0.709;
const double USD = 1.41;
double AfterConvert = 0;
Console.WriteLine("Do You Want Convert To JOD or USD J/U");
var TypeOfMoney = Console.ReadLine().ToLower();

Console.WriteLine("How Much");
double Money = double.Parse(Console.ReadLine());

if (TypeOfMoney == "j")
    AfterConvert = Money * USD;
else if (TypeOfMoney == "u")
    AfterConvert = Money * JOD;
else
    Console.WriteLine("Wrong Type");

Console.Write("The Money Before Convert is : " + Money);
Console.WriteLine(" || The Money After Convert is : " + AfterConvert);

Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");

Console.WriteLine("Age In Days");
Console.WriteLine("-------------------------------------");

DateTime currentDateTime = DateTime.Today;
Console.WriteLine("Enter Your Birth Day (dd/MM/yyyy): ");
DateTime BirthDay = DateTime.Parse(Console.ReadLine());
TimeSpan DiffrentDays = currentDateTime.Subtract(BirthDay);

Console.WriteLine("Your Age In Days Is : " + DiffrentDays + " Day");

=======
﻿
>>>>>>> origin/master
