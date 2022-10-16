// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int Get(string message)
{
   Console.WriteLine(message);
   string UserNumberStr = Console.ReadLine();
   int UserNumber = Convert.ToInt32(UserNumberStr);
   return UserNumber;
}

int NumberA = Get("Введите первое число: ");
int NumberB = Get("Введите второе число: ");

if(NumberA == NumberB * NumberB || NumberB == NumberA * NumberA)
{
    Console.WriteLine($"Число {NumberB} является квадратом числа {NumberA}");
}
else
{
    Console.WriteLine($"Число {NumberB} не является квадратом числа {NumberA}");
}
