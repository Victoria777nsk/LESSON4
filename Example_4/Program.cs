﻿// Последовательность Фибоначчи:
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1; // "||" = "или"
    else return Fibonacci (n - 1) + Fibonacci (n - 2);
}

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}