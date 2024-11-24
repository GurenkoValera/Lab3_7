using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер члена ряда Фибоначчи (n): ");
        int n = int.Parse(Console.ReadLine());

        // Получение n-ого члена ряда Фибоначчи
        int fibonacciNumber = Fibonacci(n);
        Console.WriteLine($"Член ряда Фибоначчи с номером {n} равен: {fibonacciNumber}");
    }

    // Рекурсивная функция для нахождения n-ого члена ряда Фибоначчи
    static int Fibonacci(int n)
    {
        if (n <= 0)
            return 0; // Для n = 0 возвращаем 0
        else if (n == 1)
            return 1; // Для n = 1 возвращаем 1
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); // Рекурсивный вызов
    }
}