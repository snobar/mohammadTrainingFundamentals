Console.WriteLine("Calculator");
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
