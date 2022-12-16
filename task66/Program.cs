/*Задайте значения M и N. Напишите метод, который найдёт сумму натуральных элементов в промежутке от M до N. Через рекурсию!

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите начало численного ряда число M:");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите конец численного ряда число N:");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка ввода! ПереВВедите!");
    return;
}

int sum = SumOfDigit(m, n);

Console.WriteLine($"Сумма чисел = {sum}");

int SumOfDigit(int m, int n)
{
    int sum = n;
    if (n > m)
    {
        
        sum += SumOfDigit(m, n - 1);
        // Console.WriteLine(sum);
    }
    return sum;
}