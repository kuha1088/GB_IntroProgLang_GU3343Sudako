// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Get(string message)
{
   Console.WriteLine(message);
   string UserNumberStr = Console.ReadLine();
   int UserNumber = Convert.ToInt32(UserNumberStr);
   return UserNumber;
}

int Number = Get("Введите число: ");

int Digit1 = Number / 100; // Нашли первую цифру
int Digit3 = Number % 10; // Нашли третью цифру

int Result = Math.Abs((Number - Digit1*100 - Digit3)/10);

Console.WriteLine($"Получено число: {Number}, вторая цифра этого числа {Result}");
