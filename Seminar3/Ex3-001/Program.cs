/*
Напишите программу, которая принимает на вход координаты точки (X, Y),
причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой находится эта точка.

      |
   2  |   1
      |
--------------------------------------->
      |
   3  |  4
      |

1. Получить адекватные координаты
2. Выдать номер четверти.

*/

int GetCoordinate(string message)
{
   int result;

   while(true)
   {
      Console.WriteLine(message);

      if(int.TryParse(Console.ReadLine(), out int number) && number != 0)
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

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
       return 1;
    else if (x < 0 && y > 0)
       return 2; 
    else if (x < 0 && y <0)
       return 3;
    else
       return 4;   
}

int x = GetCoordinate("Введите x: ");
int y = GetCoordinate("Введите y: ");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами ({x}, {y}) находится в {quarter} четвери.");

/*
   Два типа данных:
   1) Ссылочный тип/ Reference type (class, list, array, char ...)
   2) Значимый тип/ Value type (int, double, datetime, struct, enum, long, bool, byte)

   int TempMethod(int a)
   {
       a = 10 * a;
       return a;
   }

   int f = 12;
   TempMethod(out f);
   ConsoleWriteLine(f);//

*/





