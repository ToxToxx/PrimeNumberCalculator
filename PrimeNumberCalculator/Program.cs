// See https://aka.ms/new-console-template for more information
int number;

Console.Write("Введите число");
number = Convert.ToInt32(Console.ReadLine());

int divisors = 0;

for (int i = 1; i <= number; i++)
{
    if (number%i == 0)
    {
        divisors++;
    }
}