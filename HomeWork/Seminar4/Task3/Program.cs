/*Задача 29
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] col)
{
    for(int i = 0; i < col.Length; i++)
    col[i] = new Random().Next(-100, 100); //В условиях задачи ограничения нет, но так читабельнее
}

void PrintArray(int[] col)
{
    Console.WriteLine(string.Join(", ", col));
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);