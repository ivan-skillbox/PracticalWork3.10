//Программа подсчёта суммы карт в игре «21»

using System;

Console.WriteLine("Начало игры в 21");
int cardCount = 0;
Boolean condition = true;
do
{
  try
  {
    Console.WriteLine("\nСколько у вас карт на руках?");
    cardCount = int.Parse(Console.ReadLine());
    condition = cardCount < 1 | cardCount > 52;
    if (condition) Console.WriteLine("В нашей колоде 52 карты.");
  }
  catch (Exception)
  {
    Console.WriteLine("Ошибка: введено некорректное число.");
  }
} while (condition);


int sum = 0;
for (int i = 0; i < cardCount; i++)
{
  Console.WriteLine($"Введите номинал {i + 1}-й карты. \nДля лицевых карт J,Q,K,T соответственно возрастанию старшинства");
  string userInput = Console.ReadLine();
  switch (userInput)
  {
    case "J":
    case "Q":
    case "K":
    case "T":
      sum += 10;
      break;
    default:
      try
      {
        int cardScore = int.Parse(userInput);
        if (cardScore >= 2 & cardScore <= 10) sum += cardScore;
        else
        {
          Console.WriteLine("Введено некорректное число");
          i--;
        }
        break;
      }
      catch (Exception)
      {
        Console.WriteLine("Не удаётся обработать ввёденные данные.");
        i--;
        break;
      }

  }
}
Console.WriteLine($"Сумма карт на руках {sum}");
Console.ReadLine();