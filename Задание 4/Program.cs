
//region решение без предопределённой длины последовательности
// Наименьший элемент в последовательности
//Console.WriteLine("Поиск наименьшего элемента в последовательности");
//Console.WriteLine("Введите последовательность чисел. После ввода числа нажмите Enter");
//Console.WriteLine("Ввод пустого значения будет означать окончание последовательности");
//string userInput;
//int minValue = int.MaxValue;
//do
//{
//  userInput = Console.ReadLine();
//  int.TryParse(userInput, out int parsedInput);
//  if (parsedInput < minValue) minValue = parsedInput;
//} while (userInput.Length != 0);
//Console.WriteLine($"Минимальное число {minValue}");
//Console.ReadKey();
//endregion

Console.WriteLine("Поиск наименьшего элемента в последовательности");
Console.WriteLine("Введите длину последовательности");
int sequence = int.Parse(Console.ReadLine());
Console.WriteLine("Последовательно введите числа, разделяя ввод клавишей Enter");
int minValue = int.MaxValue;
for (int i = 0; i < sequence; i++)
{
  int input = int.Parse(Console.ReadLine());
  if (input < minValue) minValue = input;
}

Console.WriteLine($"Минимальное число {minValue}");
Console.ReadKey();