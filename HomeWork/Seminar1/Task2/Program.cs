// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число, которое хотите проверить: ");
string UserNumber1 = Console.ReadLine();
Console.Write("Введите второе число, которое хотите проверить: ");
string UserNumber2 = Console.ReadLine();
Console.Write("Введите третье число, которое хотите проверить: ");
string UserNumber3 = Console.ReadLine();
int Number1 = int.Parse(UserNumber1);
int Number2 = int.Parse(UserNumber2);
int Number3 = int.Parse(UserNumber3);

int Max = Number1;
if(Number2 > Max) Max = Number2;
if(Number3 > Max) Max = Number3;

Console.WriteLine($"max = {Max}");