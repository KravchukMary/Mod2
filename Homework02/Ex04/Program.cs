int GetNumber()
{
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetNumber();
int b = GetNumber();
int c = GetNumber();
int d = GetNumber();
int e = GetNumber();
int g = GetNumber();
int v = GetNumber();

int res = (a + b + c + d + e + g + v) / 7;
Console.WriteLine();
Console.WriteLine(res);