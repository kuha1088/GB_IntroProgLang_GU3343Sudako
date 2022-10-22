// Задача 18
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


int GetCoordinate(string msg)
{
   int result;

   while (true)
   {
      Console.WriteLine(msg); //Запрос

      if(int.TryParse(Console.ReadLine(), out var number) && number > 0 && number < 5)
      {
          result = number;
          break;
      }
      else
      {
        Console.WriteLine("Ввели не число или число равное нулю. Повторите ввод /n");
      }
   }
   
   return result;
}

int GetQuorter(int x)
{
    switch(x)
    {
        case 1:
        Console.WriteLine("x > 0 && y > 0");
        break;
        case 2:
        Console.WriteLine("x < 0 && y > 0");
        break;
        case 3:
        Console.WriteLine("x < 0 && y < 0");
        break;
        case 4:
        Console.WriteLine("x > 0 && y < 0");
        break;
        default:
        Console.WriteLine("Выход из диапазона"); // Не "1", "2", "3", "4"
        break;
    }

    return 0;
}

int x = GetCoordinate("Введите число от 1 до 4: ");
int quarter = GetQuorter(x);