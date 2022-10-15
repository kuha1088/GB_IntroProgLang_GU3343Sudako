// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число, которое хотите возвести в степень: ");
string NumberStr = Console.ReadLine();
//То что вводит пользователь с консоли это всегда тип "string"
int NumberInt = int.Parse(NumberStr);
int Result = NumberInt * NumberInt;
Console.WriteLine($"Квадрат числа {NumberInt} равен {Result}");