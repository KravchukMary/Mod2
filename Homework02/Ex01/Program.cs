int number = new Random().Next(100,1000);
int FindDigit(int number)
{
    number = new Random().Next(100, 1000);
    Console.WriteLine(number);
    int result = number % 100;
    result = result / 10;
    return result;
}
Console.WriteLine(FindDigit(number));