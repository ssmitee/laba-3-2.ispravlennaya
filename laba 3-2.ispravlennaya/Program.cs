Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());

int result = 0;

while (n >= m)
{
    n = n - m;
    result = result + 1;
}

result = result * result;

Console.WriteLine("Результат квадрата целочисленного деления n на m: " + result);