/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
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

double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

int x1Number = Get("Введите коордитнату x1: ");
int x2Number = Get("Введите коордитнату x2: ");
int y1Number = Get("Введите коордитнату y1: ");
int y2Number = Get("Введите коордитнату y2: ");
int z1Number = Get("Введите коордитнату z1: ");
int z2Number = Get("Введите коордитнату z2: ");

double dist = GetDistance(x1Number, x2Number, y1Number, y2Number, z1Number, z2Number);

Console.WriteLine($"Расстояние между точками ({x1Number}, {x2Number}, {y1Number}, {y2Number}, {z1Number}, {z2Number}) составляет {Math.Round(dist, 2)}.");