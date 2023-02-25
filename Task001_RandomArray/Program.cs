// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] array = new int[10];
Random random = new Random();
int evenCount = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write($"{array[i] + " "}");

    if (array[i] % 2 == 0)
        evenCount++;
}
Console.WriteLine();
Console.WriteLine($"the number of even numbers in the array is: {evenCount}");