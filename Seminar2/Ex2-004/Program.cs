// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int Get(string message)
{
   Console.WriteLine(message);
   string UserNumberStr = Console.ReadLine();
   int UserNumber = Convert.ToInt32(UserNumberStr);
   return UserNumber;
}

int Number = Get("Введите число: ");
int result1 = Number % 7;
int result2 = Number % 23;

if(result1 == 0 && result2 == 0)
{
    Console.WriteLine($"Число {Number} является кратным числу 7 и числу 23");
}
else
{
    Console.WriteLine($"Число {Number} не является кратным числу 7 и числу 23");
}