// // Задача 38: Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] newArray)
{
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        int min = -20;
        int max = 70;
        newArray[i] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 2);
    }
}

void PrintArray(double[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.WriteLine();
}

double MinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }
    Console.WriteLine($"Максимальный элемент: {max}");
    Console.WriteLine($"Минимальный элемент: {min}");
    return max - min;
}


int size = InputNum("Введите размер массива: ");
double[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным  элементом  равна {MinMax(myArray)}");