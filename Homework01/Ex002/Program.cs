Console.WriteLine("Вводим чмсло a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число " + a);
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine("Максимальное число " + b);
    }
    else
    {
        Console.WriteLine("Максимальное число " + c);
    }
}
