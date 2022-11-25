// Игра «Угадай число»
Console.WriteLine($"Введите число, определяющее верхнюю границу диапазона (максимум {int.MaxValue})");
int maxRange=int.Parse(Console.ReadLine());
Random Random = new Random();
int secret=Random.Next(maxRange-1);
Console.WriteLine("Угадайте число, загаданное программой");
Console.WriteLine("Для окончания игры нажмите Enter без ввода чисел");
int input;
do
{
  if (!(int.TryParse(Console.ReadLine(), out input))) break;
  if (input < secret) Console.WriteLine("Введённое число меньше загаданного");
  else if (input > secret) Console.WriteLine("Введённое число больше загаданного");
  else
  {
    Console.WriteLine($"Введённое число {input} равно загаданному числу {secret}");
    break;
  }
} while (true);
if (input != secret) Console.WriteLine($"Программа загадала число {secret}");
Console.ReadKey();