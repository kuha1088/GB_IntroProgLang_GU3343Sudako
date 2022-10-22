// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message); //Запрос

        if(int.TryParse(Console.ReadLine(), out var number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Ввели не число или число равное нулю. Повторите ввод \n");
        }
    }
    return result;
}

void Square(int n)
{
    for(int i = 1; i <= n; i++)
    {
        if(i!=n)
        Console.Write($"{i*i}, ");
        else
        Console.Write($"{i*i} ");
    }
}

int number = GetNumber("Введите число N");
Square(number);
