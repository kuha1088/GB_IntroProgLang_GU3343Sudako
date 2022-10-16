// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int Get(string message)
{
   Console.WriteLine(message);
   string NumberAStr = Console.ReadLine();
   int NumberA = Convert.ToInt32(NumberAStr);
   return NumberA;
}

int NumberA = Get("Введите первое число: ");
int NumberB = Get("Введите второе число: ");
int result = NumberB % NumberA;

if(result == 0)
{
    Console.WriteLine($"Число {NumberB} является кратным числу {NumberA}");
}
else
{
    Console.WriteLine($"Число {NumberB} не является кратным числу {NumberA}");
}
