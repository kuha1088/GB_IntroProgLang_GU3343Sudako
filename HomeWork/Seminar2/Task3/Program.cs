// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Get(string message)
{
   Console.WriteLine(message);
   string UserNumberStr = Console.ReadLine();
   int UserNumber = Convert.ToInt32(UserNumberStr);
   return UserNumber;
}

int Number = Get("Введите число: ");

if(Number == 6 || Number == 7)
{
    Console.WriteLine("Да, сегодня выходной");
}
else
{
    Console.WriteLine("Нет, сегодня будний день");
}