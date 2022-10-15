// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число, которое хотите проверить: ");
string UserNumber1 = Console.ReadLine();
Console.Write("Введите второе число, которое хотите проверить: ");
string UserNumber2 = Console.ReadLine();
int Number1 = int.Parse(UserNumber1);
int Number2 = int.Parse(UserNumber2);

if(Number1 > Number2)
{
    int Max = Number1;
    Console.WriteLine($"max = {Max}");
}
else
{
    int Max = Number2;
    Console.WriteLine($"max = {Max}");
}