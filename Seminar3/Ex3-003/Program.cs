// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2

double GetDistance(int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
    return distance;
}

int GetNumber(string msg)
{
   int userNumber;

   while (true)
   {
      Console.WriteLine(msg); //Запрос

      if(int.TryParse(Console.ReadLine(), out var number))
      {
          userNumber = number;
          break;
      }
      else
      {
        Console.WriteLine($"{number} не является числом, повторите ввод.");
      }
   }

   return userNumber;
}

int x1Number = GetNumber("Введите коордитнату x1 - ");
int x2Number = GetNumber("Введите коордитнату x2 - ");
int y1Number = GetNumber("Введите коордитнату y1 - ");
int y2Number = GetNumber("Введите коордитнату y2 - ");

double MyDistance = GetDistance(x1Number, x2Number, y1Number, y2Number);

Console.WriteLine($"Расстояние между точками ({x1Number}, {x2Number}, {y1Number}, {y2Number}) составляет {Math.Round(MyDistance, 2)}.");






