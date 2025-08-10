// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to C#, Jenkins Github lab");
int num = 12;
System.Console.WriteLine($"*Table of {num}*");
for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{num}*{i}=\t {num * i}");
}

System.Console.WriteLine("Printing Numbers from 1 to 100");
for (int i = 1; i <= 100; i++)
{ 
    System.Console.Write(i+"\t");
}