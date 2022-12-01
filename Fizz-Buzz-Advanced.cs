Console.Clear();

int number1 = 0;
int number2 = 100;
int counter = 0;

string a = " Fizz";
string b = " Buzz";
string ab = " FizzBuzz";

Console.WriteLine("Enter  fizznumber: ");
int fizzNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter buzznumber: ");
int buzzNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine();

for (int i = 0; i < 100; i++)
{
    Console.Write("*");
}

System.Console.WriteLine();

while (number1 <= number2)
{
    counter++;

    if (number1 % fizzNumber == 0 && number1 % buzzNumber != 0)
    {
        Console.Write($"     {a}");
    }
    else if (number1 % fizzNumber != 0 && number1 % buzzNumber == 0)
    {
        Console.Write($"     {b}");
    }

    else if (number1 % fizzNumber == 0 && number1 % buzzNumber == 0)
    {
        Console.Write($"     {ab}");
    }
    else
    {
        Console.Write($"     {number1}");
    }

    if (number1 > number2)
    {
        Console.Write(",");
    }
    if (counter % 10 == 0 && counter != 0)
    {
        Console.WriteLine();
    }
    number1++;
}

Console.WriteLine("");

for (int i = 0; i < 100; i++)
{
    Console.Write("*");
}