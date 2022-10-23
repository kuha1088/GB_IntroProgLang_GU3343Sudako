/*Задача 25
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Get(string msg)
{
    Console.WriteLine(msg);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out var userNumber))
        return userNumber;
        else
        Console.WriteLine("Введенное значение не удовлетворяет требованиям задачи\n");
    }
}

int Degree(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
    result = result*a;
    }
    return result;
}

int number1 = Get("Введите число A (база): ");
int number2 = Get("Введите число B (степень): ");
int raised = Degree(number1, number2);
Console.WriteLine($"Число A ({number1}) в степени B({number2}) = {raised})");