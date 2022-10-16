// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Get(string message)
{
   Console.WriteLine(message);
   string UserNumberStr = Console.ReadLine();
   int UserNumber = Convert.ToInt32(UserNumberStr);
   return UserNumber;
}

int Number = Get("Введите число: ");

int Digit3 = Math.Abs(Number % 10); // Нашли третью цифру для трехзначного числа

if(Number < 1000 && Number > 99 || Number > -1000 && Number < -99)
Console.WriteLine($"Третья цифра {Digit3}");
else
Console.WriteLine("Число не трехзначное, третьей цифры нет");

