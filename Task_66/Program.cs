// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Sum(int M, int N)
{
    if (M == N) return M;
    return M + Sum(M + 1, N);
}

int first = InputNum("введите число M: ");
int second = InputNum("введите число N: ");
int sum = Sum(first, second);
Console.WriteLine($"Сумма чисел от {first} до {second} равна {sum}");
