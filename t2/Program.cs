// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 


void Main()
{

    int m = readNumber("Введите число M");
    int n = readNumber("Введите число N");
    int result = A(m, n);
    Console.WriteLine(result);
}
int readNumber(string msg)
{
    Console.WriteLine(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return A(n - 1, 1);
    return A(n - 1, A(n, m - 1));
}
Main();

