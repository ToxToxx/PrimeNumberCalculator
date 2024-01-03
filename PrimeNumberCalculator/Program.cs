// See https://aka.ms/new-console-template for more information
int number;

Console.Write("Введите число для проверки на простоту: ");
number = Convert.ToInt32(Console.ReadLine());

int divisors = 0;

for (int i = 1; i <= number; i++)
{
    if (number%i == 0)
    {
        divisors++;
    }
}


if (divisors == 2)
{
    Console.WriteLine("Это простое число");
}
else
{
    Console.WriteLine("это не простое число");
}
Console.ReadLine();