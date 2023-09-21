// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Ackerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return Ackerman(M - 1, 1);
    return Ackerman(M - 1, Ackerman(M, N - 1));
}

int first = InputNum("введите число M: ");
int second = InputNum("введите число N: ");
int ack = Ackerman(first, second);
Console.WriteLine($"Функция Аккермана для чисел {first} и {second} равна {ack}");

