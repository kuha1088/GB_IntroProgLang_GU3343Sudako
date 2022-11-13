/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int message = Convert.ToInt32(Console.ReadLine());
    return message;
}

void Fibonacci(int n)
{
    if(n==0)
    {
        Console.WriteLine("f(0) = 0");
        return;
    }
    if(n==1)
    {
        Console.WriteLine("f(0) = 0, f(1) = 1");
        return;
    }
    int[] fib = new int[n];
    fib[0]=0;
    fib[1]=1;
    Console.Write($"{fib[0]}  {fib[1]}  ");
    for (int i = 2; i < n; i++)
    {
        fib[i]=fib[i-1]+fib[i-2];
        Console.Write($"{fib[i]}  ");
    }
}
int n = GetNumber("Введите число: ");
Fibonacci(n);
