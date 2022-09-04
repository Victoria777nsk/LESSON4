Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Factorial (int n) // Метод, выводящий число и его факториал.
{
    if (n == 1) return 1; // 1! = 1
    else return n * Factorial (n - 1); // Текущее значение умножаем на факториал предыдущего числа.
}
Console.Write($"{n}! = {Factorial(n)}"); // 3! = 1 * 2 * 3 = 6
Console.WriteLine();

double Factorials (int n) // Метод, выводящий факториалы всех чисел до заданного.
{
    if (n == 1) return 1;
    else return n * Factorials (n - 1);
}
Console.WriteLine();
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}! = {Factorials(i)}");
}
