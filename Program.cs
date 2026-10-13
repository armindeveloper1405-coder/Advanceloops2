Console.Write("Enter your number: ");
string number = Console.ReadLine();
int n = int.Parse(number);

//----------------------------------------------------------
int sumFor = 0;
int productFor = 1;

for (int i = 1; i <= n; i++)
{
    sumFor += i;
    productFor *= i;
}

Console.WriteLine("\nUsing for loop:");
Console.WriteLine("Sum = " + sumFor);
Console.WriteLine("Product = " + productFor);
//----------------------------------------------------------
int sumWhile = 0;
int productWhile = 1;
int j = 1;

while (j <= n)
{
    sumWhile += j;
    productWhile *= j;
    j++;
}

Console.WriteLine("\nUsing while loop:");
Console.WriteLine("Sum = " + sumWhile);
Console.WriteLine("Product = " + productWhile);
