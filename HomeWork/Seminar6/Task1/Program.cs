/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int Get(string msg)
{
    int result = 0;
    int n;

    Console.WriteLine(msg);
    while(true)
    {
        Console.Write("Введите число: ");
        var userNumber = Console.ReadLine();
        if (userNumber == "Final") break; // Параметры прерывания условиями задачи не предусмотрены, поэтому выбрал сам       
        n = Convert.ToInt32(userNumber);
        if (n > 0) result++;
    }
    
    return result;
}

int result = Get("Введите числа, для выхода введите \"Final\"");
Console.WriteLine($"Сумма положительных чисел введенных пользователем = {result}");

