/*Напишите метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Введите первую переменную - число M:");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите вторую переменную - число N:");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка ввода! ПереВВедите!");
    return;
}
int resultakkerrfunk = AkkermannFunction(m, n);
Console.WriteLine($"Результат ф-ии Аккеманна = {resultakkerrfunk}");

int AkkermannFunction(int m, int n)
{
    if(m == 0) return n + 1;
    if(m != 0 && n == 0) return AkkermannFunction(m - 1, 1);
    if(m > 0 && n > 0) return AkkermannFunction(m - 1, AkkermannFunction(m, n - 1));
    return AkkermannFunction(m, n);
}
