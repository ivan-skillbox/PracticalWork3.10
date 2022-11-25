// Проверка простого числа
Console.WriteLine("Для выхода нажмите Ctrl+C");
while (true)
{
  try
  {
    Console.WriteLine("\nВведите целое число");
    int number = int.Parse(Console.ReadLine());
    if (number > 1)
    {
      #region решение задачи
      int i = number - 1;
      while (number % i != 0)
      {
        i--;
      }
      Console.WriteLine(i == 1 ? $"Число {number} простое" : $"Число {number} не простое");
      #endregion
    }
    else if (number == 1)
    {
      Console.WriteLine($"Число {number} простое");
    }
    else
    {
      Console.WriteLine("Отрицательное число не может быть простым.");
    }
  }
  catch (Exception)
  {
    Console.WriteLine($"Ошибка. Введите число. Макс. {int.MaxValue}");
  }
}