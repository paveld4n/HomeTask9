/*Задайте значение N. Напишите метод, который выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите число N:");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedN || n <= 0)
{
    Console.WriteLine("Ошибка ввода! ПереВВедите!");
    return;
}

PrintNumbers(n);

void PrintNumbers(int x, int i = 1) // Значение I задается как значение по умолчанию. Соответственно его можно не передавать методом
{
    if(i > x)
    {
        return;
    }
    Console.Write($"{x} ");
    PrintNumbers(x - 1);
}