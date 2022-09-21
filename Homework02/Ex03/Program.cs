Console.WriteLine("Введите номер дня недели: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i >= 1 & i <= 5) Console.WriteLine("Будний день");
if (i == 6 | i == 7) Console.WriteLine("Выходной");
if (i > 7) Console.WriteLine("Введено некорректное значение");