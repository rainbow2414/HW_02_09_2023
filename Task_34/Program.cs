﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(100, 1000);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}
void CountEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) 
            count += 1;
    }
    Console.WriteLine($"Количество четных чисел в массиве : {count}"); 
}
int size = InputNum("Введите размер массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
CountEvenElements(myArray);