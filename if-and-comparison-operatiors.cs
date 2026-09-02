Console.WriteLine("if and comparison operators");
Console.WriteLine("if operator");
String? ageAsString = Console.ReadLine();
if (!int.TryParse(ageAsString, out int age))
{
    Console.WriteLine("You did not enter a valid number.");
}
else
{
    if (age < 18)
    {
        Console.WriteLine("You are a minor.");
    }
    else if (age >= 18 && age < 65)
    {
        Console.WriteLine("You are an adult.");
    }
    else
    {
        Console.WriteLine("You are a senior citizen.");
    }

    Console.WriteLine("do while operator");
    do
    {
        Console.WriteLine("Enter age (0 to exit):");
        String? input = Console.ReadLine();
        if (!int.TryParse(ageAsString2, out age))
        {
            Console.WriteLine("You did not enter a valid number.");
            continue;
        }

        Console.WriteLine($"Your age is: {age}");
    } while (true);

    Console.WriteLine("do while operator 2");
    String? ageAsString;
    bool firstTry = true;
    do
    {
        if (!firstTry)
        {
            Console.WriteLine("You did not enter a valid number.");
        }
        Console.Write("Enter age:");
        ageAsString = Console.ReadLine();
        Console.WriteLine($"Your age is: {age}");
        firstTry = false;
    } while (!int.TryParse(ageAsString, out age) || age < 0);

    if (age < 18)
    {
        Console.WriteLine("You are a minor.");
    }
    else if (age >= 18 && age < 65)
    {
        Console.WriteLine("You are an adult.");
    }
    else
    {
        Console.WriteLine("You are a senior citizen.");
    }
}