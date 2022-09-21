
Console.Clear();
int n = new Random().Next(10, 100);//[10, 100)
Console.WriteLine("Здравствуй, дорогой пользователь!");
Console.WriteLine("Загадано число ");
Console.WriteLine(n);
int a = n / 10;
int b = n % 10;

Console.WriteLine("Максимальная цифра: ");
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}

