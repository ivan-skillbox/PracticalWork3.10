//Приложение по определению чётного или нечётного числа

Console.WriteLine("Определение чётного и нечётного числа.\nВведите число");
int num = int.Parse(Console.ReadLine());
if (num %2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}
Console.ReadKey();
