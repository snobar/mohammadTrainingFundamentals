Console.WriteLine("\t\t\t\tMultiplication_1_TO_10");

for (int P_Head = 1; P_Head <= 10; ++P_Head)
{
    Console.Write("\t" + P_Head);
}

Console.WriteLine("\n______________________________________________________________________________________\n");

for (int i = 1; i <= 10; i++)
{
    if (i < 10)
        Console.Write(" " + i + "   |");
    else
        Console.Write(i + "  |");

    for (int j = 1; j <= 10; j++)
    {
        Console.Write("\t" + (i * j));
    }

    Console.WriteLine();
}

