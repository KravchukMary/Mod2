Console.Write("Введи число: ");
string Number = Console.ReadLine();


if (Number.Length > 2)
{
  Console.WriteLine("третья цифра -> " + Number[2]);
}
else {
  Console.WriteLine("-> нет третьей цифры");
}
