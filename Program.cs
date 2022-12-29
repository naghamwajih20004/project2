// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

int num1, num2, sum, i, j;

Console.WriteLine("Please Enter The Primer Number");

Console.WriteLine("Ent num1");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ent num2");
num2 = int.Parse(Console.ReadLine());

for (i = num1; i<= num2; i++)
{
    sum = 0;

    for (j = 2; j <= i / 2 ; j++ )
    {
       if (i % j ==0)
            {
                sum++;
                break;
            }
    }
    if (sum == 0 && i != 1)
        Console.WriteLine("{0}", i);
}
Console.WriteLine("Ending Process");
Console.ReadKey();
