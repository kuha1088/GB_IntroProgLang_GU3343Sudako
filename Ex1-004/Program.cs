// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
string UserNumber = Console.ReadLine();
int Number= int.Parse(UserNumber);

for (int i = -Number; i < Number; i++)
{
    Console.Write($"{i}, ");
}

