Console.Clear();

int number1 = 0;
int number2 = 100;
int counter = 0;

string fizz = " Fizz";
string buzz = " Buzz";
string fizzbuzz = " FizzBuzz";


Console.WriteLine();

for (int i = 0; i < 100; i++)
{
    Console.Write("*");
}

System.Console.WriteLine();

while (number1 <= number2)
{
    counter++;

    if (number1 % 3 == 0 && number1 % 5 != 0)
    {
        Console.Write($"     {fizz}");
    }
    else if (number1 % 3 != 0 && number1 % 5 == 0)
    {
        Console.Write($"     {buzz}");
    }

    else if (number1 % 3 == 0 && number1 % 5 == 0)
    {
        Console.Write($"     {fizzbuzz}");
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