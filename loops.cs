Console.WriteLine("While loop");
int counter = 1;
while (counter <= 10)
{
    Console.WriteLine($"Counter is {counter}");
    counter++;
}

Console.WriteLine("While loop2");
counter = 1;
while (true)
{
    Console.WriteLine($"Counter is {counter}");
    counter++;
    if (counter == 10) { break; }
}