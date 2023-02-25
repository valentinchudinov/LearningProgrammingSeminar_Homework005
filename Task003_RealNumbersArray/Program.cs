// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

double[] array = new double[5];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Enter {0} element of array: ", i + 1);
    array[i] = double.Parse(Console.ReadLine());
}

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
    else if (array[i] > max)
        max = array[i];
}

Console.Write($"difference between max and min meaning is {max - min} ");
