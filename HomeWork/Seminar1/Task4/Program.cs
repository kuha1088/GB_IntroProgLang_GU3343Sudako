// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
string UserNumber = Console.ReadLine();
int Number = int.Parse(UserNumber);

for (int i = 2; i <= Number; i = i + 2)
{
    Console.Write($"{i}, ");
}
