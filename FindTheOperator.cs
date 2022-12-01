System.Console.Write("Please enter a operand: ");
int operand1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Please enter a second operand: ");
int operand2 = int.Parse(Console.ReadLine()!);
System.Console.Write("Please enter the result of the two operands: ");
int result = int.Parse(Console.ReadLine()!);



 if (operand1 * operand2 == result || operand2 * operand1 == result)
{
System.Console.WriteLine("The two operands were multiplied");
}
else if (operand1 + operand2 == result || operand2 + operand1 == result)
{
System.Console.WriteLine("The two operands were added ");
}
else if (operand1 / operand2 == result || operand2 / operand1 == result)
{
System.Console.WriteLine("The two operands were divided ");
}
else if (operand1 - operand2 == result || operand2 - operand1 == result)
{
System.Console.WriteLine("The two operand were subtracted ");
}