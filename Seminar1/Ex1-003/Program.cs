// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.Write("Какой по счету сегодня день недели?: ");
string UserNumber = Console.ReadLine();
int DayNumber= int.Parse(UserNumber);
if (DayNumber == 1) Console.Write("понедельник");
if (DayNumber == 2) Console.Write("вторник");
if (DayNumber == 3) Console.Write("среда");
if (DayNumber == 5) Console.Write("пятница");
if (DayNumber == 6) Console.Write("суббота");
if (DayNumber == 7) Console.Write("воскресенье");
