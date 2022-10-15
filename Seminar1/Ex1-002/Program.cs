// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число 1, которое хотите проверить: ");
string NumberStr1 = Console.ReadLine();
Console.WriteLine("Введите число 2, которое хотите проверить: ");
string NumberStr2 = Console.ReadLine();
int NumberInt1 = int.Parse(NumberStr1);
int NumberInt2 = int.Parse(NumberStr2);

int Result = NumberInt1 % NumberInt2;
if (Result == 0)
{
    Console.WriteLine($"Является");
}
else
{
    Console.WriteLine($"Не является");
}